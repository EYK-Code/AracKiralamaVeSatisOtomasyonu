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
    public partial class FRMAracIslemleri : Form
    {
        private readonly MyDbContext _context;
        public FRMAracIslemleri()
        {
            InitializeComponent();
            _context = new MyDbContext();
        }

        private void FRMAracIslemleri_Load(object sender, EventArgs e)
        {
            cmbYakitTuru.Items.AddRange(new[] { "Benzin", "Dizel", "Elektrik", "Hibrit" });
            cmbSanzimanTipi.Items.AddRange(new[] { "Manuel", "Otomatik" });
            cmbDurum.Items.AddRange(new[] { "Kiralık", "Satılık" });
            cmbMevcutDurum.Items.AddRange(new[] { "Kirada", "Satıldı", "Boşta" });
            cmbRenk.Items.AddRange(new[] { "Kiremit", "Kırmızı", "Beyaz", "Siyah", "Gri" });
            var kategoriler = _context.Kategori.ToList();
            cmbKategori.DisplayMember = "KategoriAdi";
            cmbKategori.ValueMember = "Id";
            cmbKategori.DataSource = kategoriler;
            Listele();

        }

        private void Listele()
        {
            var aracListesi = _context.Arac
                .Include(a => a.Kategori)
                .Select(a => new
                {
                    a.Id,
                    a.Marka,
                    a.Model,
                    a.Yil,
                    a.Kilometre,
                    a.YakitTuru,
                    a.SanzimanTipi,
                    a.Durum,
                    a.MevcutDurum,
                    a.Renk,
                    KategoriAdi = a.Kategori.KategoriAdi
                }).ToList();
            dgvAraclar.DataSource = aracListesi;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Kategori seçimi kontrolü
                if (cmbKategori.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir kategori seçin.");
                    return;
                }

                // Şanzıman tipi kontrolü
                if (cmbSanzimanTipi.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir şanzıman tipi seçin.");
                    return;
                }

                // Yakıt türü kontrolü
                if (cmbYakitTuru.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir yakıt türü seçin.");
                    return;
                }

                // Durum kontrolü
                if (cmbDurum.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir durum seçin.");
                    return;
                }

                // Mevcut durum kontrolü
                if (cmbMevcutDurum.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir mevcut durum seçin.");
                    return;
                }

                // Renk kontrolü
                if (cmbRenk.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir renk seçin.");
                    return;
                }

                // Marka ve model kontrolü
                if (string.IsNullOrWhiteSpace(txtMarkaBilgisi.Text))
                {
                    MessageBox.Show("Lütfen marka bilgisini girin.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtModelBilgisi.Text))
                {
                    MessageBox.Show("Lütfen model bilgisini girin.");
                    return;
                }

                // Yıl ve kilometre kontrolü
                if (nudYil.Value < 1900 || nudYil.Value > 2100)
                {
                    MessageBox.Show("Lütfen geçerli bir yıl girin (1900-2100 arası).");
                    return;
                }
                if (nudKM.Value < 0)
                {
                    MessageBox.Show("Lütfen geçerli bir kilometre değeri girin.");
                    return;
                }

                // Yeni araç ekleme
                var yeniArac = new Arac
                {
                    Marka = txtMarkaBilgisi.Text,
                    Model = txtModelBilgisi.Text,
                    Yil = (int)nudYil.Value,
                    Kilometre = (int)nudKM.Value,
                    YakitTuru = cmbYakitTuru.Text,
                    SanzimanTipi = cmbSanzimanTipi.Text,
                    Durum = cmbDurum.Text,
                    MevcutDurum = cmbMevcutDurum.Text,
                    Renk = cmbRenk.Text,
                    KategoriId = (int)cmbKategori.SelectedValue
                };

                _context.Arac.Add(yeniArac);
                _context.SaveChanges();
                MessageBox.Show("Araç başarıyla eklendi.");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                // Araç seçimi kontrolü
                if (dgvAraclar.CurrentRow == null || dgvAraclar.CurrentRow.Cells["Id"].Value == null)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz aracı seçin.");
                    return;
                }

                // Seçilen aracın ID'sini al
                int aracId = (int)dgvAraclar.CurrentRow.Cells["Id"].Value;

                // Veritabanından aracı bul
                var arac = _context.Arac.Find(aracId);
                if (arac != null)
                {
                    // Aracı sil
                    _context.Arac.Remove(arac);
                    _context.SaveChanges();
                    MessageBox.Show("Araç başarıyla silindi.");
                    Listele();
                }
                else
                {
                    MessageBox.Show("Araç bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAraclar.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz aracı seçin.");
                    return;
                }

                int aracId = (int)dgvAraclar.CurrentRow.Cells["Id"].Value;
                var arac = _context.Arac.Find(aracId);
                if (arac == null)
                {
                    MessageBox.Show("Araç bulunamadı.");
                    return;
                }

                // Güncelleme kontrolleri
                if (cmbKategori.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir kategori seçin.");
                    return;
                }
                if (cmbSanzimanTipi.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir şanzıman tipi seçin.");
                    return;
                }
                if (cmbYakitTuru.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir yakıt türü seçin.");
                    return;
                }
                if (cmbDurum.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir durum seçin.");
                    return;
                }
                if (cmbMevcutDurum.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir mevcut durum seçin.");
                    return;
                }
                if (cmbRenk.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir renk seçin.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMarkaBilgisi.Text))
                {
                    MessageBox.Show("Lütfen marka bilgisini girin.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtModelBilgisi.Text))
                {
                    MessageBox.Show("Lütfen model bilgisini girin.");
                    return;
                }
                if (nudYil.Value < 1900 || nudYil.Value > 2100)
                {
                    MessageBox.Show("Lütfen geçerli bir yıl girin (1900-2100 arası).");
                    return;
                }
                if (nudKM.Value < 0)
                {
                    MessageBox.Show("Lütfen geçerli bir kilometre değeri girin.");
                    return;
                }

                // Araç güncelleme
                arac.Marka = txtMarkaBilgisi.Text;
                arac.Model = txtModelBilgisi.Text;
                arac.Yil = (int)nudYil.Value;
                arac.Kilometre = (int)nudKM.Value;
                arac.YakitTuru = cmbYakitTuru.Text;
                arac.SanzimanTipi = cmbSanzimanTipi.Text;
                arac.Durum = cmbDurum.Text;
                arac.MevcutDurum = cmbMevcutDurum.Text;
                arac.Renk = cmbRenk.Text;
                arac.KategoriId = (int)cmbKategori.SelectedValue;

                _context.SaveChanges();
                MessageBox.Show("Araç başarıyla güncellendi.");
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltreleMevcutDurum();
        }

        private void FiltreleMevcutDurum()
        {
            cmbMevcutDurum.Items.Clear();
            if (cmbDurum.Text == "Kiralık")
            {
                cmbMevcutDurum.Items.Add("Boşta");
                cmbMevcutDurum.Items.Add("Kirada");
            }
            else if (cmbDurum.Text == "Satılık")
            {
                cmbMevcutDurum.Items.Add("Boşta");
                cmbMevcutDurum.Items.Add("Satıldı");
            }
            if (cmbMevcutDurum.Items.Count > 0)
            {
                cmbMevcutDurum.SelectedIndex = 0;
            }
        }

        private void btnKiraRaporu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiralama raporunu listele
                var kiraRaporu = _context.Kiralama
                    .Include(k => k.Arac)
                    .Include(k => k.Musteri)
                    .Select(k => new
                    {
                        k.Id,
                        Arac = k.Arac.Marka + " " + k.Arac.Model,
                        Musteri = k.Musteri.AdSoyad,
                        k.BaslangicTarihi,
                        k.BitisTarihi,
                        k.GunlukUcret,
                        k.ToplamTutar
                    }).ToList();

                // DataGridView'e verileri bağla
                dgvAraclar.DataSource = kiraRaporu;
                MessageBox.Show("Kira raporu başarıyla yüklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kira raporu yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnSatisRaporu_Click(object sender, EventArgs e)
        {
            try
            {
                // Satış raporunu listele
                var satisRaporu = _context.Satis
                    .Include(s => s.Arac)
                    .Include(s => s.Musteri)
                    .Select(s => new
                    {
                        s.Id,
                        Arac = s.Arac.Marka + " " + s.Arac.Model,
                        Musteri = s.Musteri.AdSoyad,
                        s.SatisTarihi,
                        s.SatisFiyati,
                        s.OdemeTipi
                    }).ToList();

                // DataGridView'e verileri bağla
                dgvAraclar.DataSource = satisRaporu;
                MessageBox.Show("Satış raporu başarıyla yüklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Satış raporu yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                // Tüm araç bilgilerini listele
                Listele();
                MessageBox.Show("Tüm araç bilgileri başarıyla yüklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}
