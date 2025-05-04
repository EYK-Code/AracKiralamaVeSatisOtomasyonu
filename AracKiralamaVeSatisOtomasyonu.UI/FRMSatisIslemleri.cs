using AracKiralamaVeSatisOtomasyonu.UI.Context;
using AracKiralamaVeSatisOtomasyonu.UI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaVeSatisOtomasyonu.UI
{
    public partial class FRMSatisIslemleri : Form
    {
        private readonly MyDbContext _context;
        public FRMSatisIslemleri()
        {
            InitializeComponent();
            _context = new MyDbContext();
        }

        private void FRMSatisIslemleri_Load(object sender, EventArgs e)
        {
            cmbMusteriAdi.DisplayMember = "AdSoyad";
            cmbMusteriAdi.ValueMember = "Id";
            cmbMusteriAdi.DataSource = _context.Musteri.ToList();
            AraclariListele();
            Listele();
            cmbOdemeTuru.Items.Add("Nakit");
            cmbOdemeTuru.Items.Add("Taksitli");
            cmbOdemeTuru.SelectedIndex = 0;
        }

        private void Listele()
        {
            var satislar = _context.Satis
                .Include(c => c.Musteri)
                .Include(c => c.Arac)
                .Select(s => new
                {
                    s.Id,
                    Arac = s.Arac.Marka + " " + s.Arac.Model,
                    Musteri = s.Musteri.AdSoyad,
                    s.SatisTarihi,
                    s.SatisFiyati,
                    s.OdemeTipi
                }).ToList();
            dgvSatislar.DataSource = satislar;
        }

        private void AraclariListele()
        {
            cmbArac.DataSource = _context.Arac
                .Where(a => a.Durum == "Satılık" && a.MevcutDurum == "Boşta")
                .ToList();
            cmbArac.DisplayMember = "Marka";
            cmbArac.ValueMember = "Id";
        }


        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            // Araç seçimi kontrolü
            if (cmbArac.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir araç seçin.");
                return;
            }

            // Müşteri seçimi kontrolü
            if (cmbMusteriAdi.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
                return;
            }

            // Fiyat kontrolü
            if (nudFiyat.Value <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir fiyat girin.");
                return;
            }

            // Ödeme türü kontrolü
            if (cmbOdemeTuru.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ödeme türü seçin.");
                return;
            }

            try
            {
                decimal satisFiyati = nudFiyat.Value;
                int aracId = (int)cmbArac.SelectedValue;

                // Araç kontrolü
                var arac = _context.Arac.Find(aracId);
                if (arac == null)
                {
                    MessageBox.Show("Seçilen araç bulunamadı.");
                    return;
                }

                // Ödeme türüne göre fiyat güncellemesi
                if (cmbOdemeTuru.SelectedItem.ToString() == "Taksitli")
                {
                    satisFiyati *= 1.2m;
                }
                else
                {
                    arac.Durum = "Kiralık";
                    arac.MevcutDurum = "Kiralık";
                }

                // Satış işlemi oluşturma
                var satis = new Satis
                {
                    AracId = aracId,
                    MusteriId = (int)cmbMusteriAdi.SelectedValue,
                    SatisFiyati = satisFiyati,
                    SatisTarihi = DateTime.Now,
                    OdemeTipi = cmbOdemeTuru.SelectedItem.ToString()
                };

                // Araç durumunu güncelleme
                arac.MevcutDurum = "Satıldı";

                // Veritabanı işlemleri
                _context.Satis.Add(satis);
                _context.SaveChanges();

                MessageBox.Show("Araç başarıyla satıldı.");

                // Listeleme işlemleri
                Listele();
                AraclariListele();
            }
            catch (Exception ex)
            {
                // Genel hata yakalama
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}
