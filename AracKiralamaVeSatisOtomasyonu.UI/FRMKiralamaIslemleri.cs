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
    public partial class FRMKiralamaIslemleri : Form
    {
        private readonly MyDbContext _context;
        public FRMKiralamaIslemleri()
        {
            InitializeComponent();
            _context = new MyDbContext();
        }

        private void FRMKiralamaIslemleri_Load(object sender, EventArgs e)
        {
            cmbMusteriAdi.DisplayMember = "AdSoyad";
            cmbMusteriAdi.ValueMember = "Id";
            cmbMusteriAdi.DataSource = _context.Musteri.ToList();
            AraclariListele();
            Listele();

        }

        private void Listele()
        {
            var kiralamalar = _context.Kiralama
                .Include(c => c.Musteri)
                .Include(c => c.Arac)
                .Select(k => new
                {
                    k.Id,
                    Arac = k.Arac.Marka + " " + k.Arac.Model,
                    Musteri = k.Musteri.AdSoyad,
                    k.BaslangicTarihi,
                    k.BitisTarihi,
                    k.GunlukUcret,
                    k.ToplamTutar,
                }).ToList();
            dgvKiralamalar.DataSource = kiralamalar;
        }

        private void AraclariListele()
        {
            cmbArac.DataSource = _context.Arac
                .Where(a => a.Durum == "Kiralık" && a.MevcutDurum == "Boşta")
                .ToList();
            cmbArac.DisplayMember = "Marka";
            cmbArac.ValueMember = "Id";
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            // Müşteri seçimi kontrolü
            if (cmbMusteriAdi.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
                return;
            }

            // Araç seçimi kontrolü
            if (cmbArac.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir araç seçin.");
                return;
            }

            // Tarih kontrolü
            DateTime baslangicTarihi = dtpBaslangicTarihi.Value;
            DateTime bitisTarihi = dtpBitisTarihi.Value;
            if (bitisTarihi <= baslangicTarihi)
            {
                MessageBox.Show("Bitiş tarihi başlangıç tarihinden önce veya aynı olamaz.");
                return;
            }

            // Günlük ücret kontrolü
            decimal gunlukUcret = nudGunlukUcret.Value;
            if (gunlukUcret <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir günlük ücret girin.");
                return;
            }

            try
            {
                // Toplam gün ve toplam tutar hesaplama
                int toplamGun = (bitisTarihi - baslangicTarihi).Days + 1;
                decimal toplamTutar = gunlukUcret * toplamGun;

                // Araç kontrolü
                int aracId = (int)cmbArac.SelectedValue;
                var arac = _context.Arac.Find(aracId);
                if (arac == null)
                {
                    MessageBox.Show("Seçilen araç bulunamadı.");
                    return;
                }

                // Araç durum kontrolü
                if (arac.MevcutDurum != "Boşta")
                {
                    MessageBox.Show("Seçilen araç şu anda kiralanamaz.");
                    return;
                }

                // Kiralama işlemi oluşturma
                var kiralama = new Kiralama
                {
                    AracId = aracId,
                    MusteriId = (int)cmbMusteriAdi.SelectedValue,
                    BaslangicTarihi = baslangicTarihi,
                    BitisTarihi = bitisTarihi,
                    GunlukUcret = gunlukUcret,
                    ToplamTutar = toplamTutar
                };

                // Araç durumunu güncelleme
                arac.MevcutDurum = "Kirada";

                // Veritabanı işlemleri
                _context.Kiralama.Add(kiralama);
                _context.SaveChanges();

                MessageBox.Show("Araç başarıyla kiralandı.");

                // Listeleme işlemleri
                AraclariListele();
                Listele();
            }
            catch (Exception ex)
            {
                // Genel hata yakalama
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}
