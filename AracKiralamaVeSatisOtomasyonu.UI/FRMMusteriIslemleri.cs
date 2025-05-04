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
    public partial class FRMMusteriIslemleri : Form
    {
        private readonly MyDbContext _db;
        public FRMMusteriIslemleri()
        {
            InitializeComponent();
            _db = new MyDbContext();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Gerekli alanların kontrolü
                if (string.IsNullOrWhiteSpace(txtMusteriAdSoyad.Text))
                {
                    MessageBox.Show("Lütfen müşteri adını ve soyadını girin.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMusteriTelefon.Text))
                {
                    MessageBox.Show("Lütfen müşteri telefon numarasını girin.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMusteriEmail.Text))
                {
                    MessageBox.Show("Lütfen müşteri e-posta adresini girin.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMusteriAdres.Text))
                {
                    MessageBox.Show("Lütfen müşteri adresini girin.");
                    return;
                }

                // Yeni müşteri ekleme
                Musteri musteri = new Musteri
                {
                    AdSoyad = txtMusteriAdSoyad.Text,
                    Telefon = txtMusteriTelefon.Text,
                    Email = txtMusteriEmail.Text,
                    Adres = txtMusteriAdres.Text
                };

                _db.Musteri.Add(musteri);
                _db.SaveChanges();
                MessageBox.Show("Müşteri başarıyla eklendi.");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void Listele()
        {
            dgvMusteriler.DataSource = _db.Musteri.Select(m => new
            {
                m.Id,
                m.AdSoyad,
                m.Telefon,
                m.Email,
                m.Adres
            }).ToList();
        }

        private void Temizle()
        {
            txtMusteriAdres.Text = txtMusteriAdSoyad.Text = txtMusteriEmail.Text = txtMusteriTelefon.Text = string.Empty;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMusteriler.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz müşteriyi seçin.");
                    return;
                }

                int id = (int)(dgvMusteriler.CurrentRow.Cells["Id"].Value);
                var musteri = _db.Musteri.Find(id);
                if (musteri != null)
                {
                    _db.Musteri.Remove(musteri);
                    _db.SaveChanges();
                    MessageBox.Show("Müşteri başarıyla silindi.");
                    Listele();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Müşteri bulunamadı.");
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
                if (dgvMusteriler.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz müşteriyi seçin.");
                    return;
                }

                int id = (int)(dgvMusteriler.CurrentRow.Cells["Id"].Value);
                var musteri = _db.Musteri.Find(id);
                if (musteri == null)
                {
                    MessageBox.Show("Müşteri bulunamadı.");
                    return;
                }

                // Gerekli alanların kontrolü
                if (string.IsNullOrWhiteSpace(txtMusteriAdSoyad.Text))
                {
                    MessageBox.Show("Lütfen müşteri adını ve soyadını girin.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMusteriTelefon.Text))
                {
                    MessageBox.Show("Lütfen müşteri telefon numarasını girin.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMusteriEmail.Text))
                {
                    MessageBox.Show("Lütfen müşteri e-posta adresini girin.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMusteriAdres.Text))
                {
                    MessageBox.Show("Lütfen müşteri adresini girin.");
                    return;
                }

                // Müşteri güncelleme
                musteri.AdSoyad = txtMusteriAdSoyad.Text;
                musteri.Telefon = txtMusteriTelefon.Text;
                musteri.Email = txtMusteriEmail.Text;
                musteri.Adres = txtMusteriAdres.Text;

                _db.SaveChanges();
                MessageBox.Show("Müşteri başarıyla güncellendi.");
                Listele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void FRMMusteriIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvMusteriler.CurrentRow != null)
                {
                    txtMusteriAdSoyad.Text = dgvMusteriler.CurrentRow.Cells["AdSoyad"].Value.ToString();
                    txtMusteriTelefon.Text = dgvMusteriler.CurrentRow.Cells["Telefon"].Value.ToString();
                    txtMusteriEmail.Text = dgvMusteriler.CurrentRow.Cells["Email"].Value.ToString();
                    txtMusteriAdres.Text = dgvMusteriler.CurrentRow.Cells["Adres"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }
    }
}

