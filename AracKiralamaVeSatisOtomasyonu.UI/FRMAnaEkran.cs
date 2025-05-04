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
    public partial class FRMAnaEkran : Form
    {
        public FRMAnaEkran()
        {
            InitializeComponent();
        }

        private void btnAraclar_Click(object sender, EventArgs e)
        {
            try
            {
                FRMAracIslemleri fRMAracIslemleri = new();
                fRMAracIslemleri.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Araç işlemleri ekranı açılırken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnKiralamaIslemleri_Click(object sender, EventArgs e)
        {
            try
            {
                FRMKiralamaIslemleri fRMKiralamaIslemleri = new();
                fRMKiralamaIslemleri.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kiralama işlemleri ekranı açılırken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnSatisIslemleri_Click(object sender, EventArgs e)
        {
            try
            {
                FRMSatisIslemleri fRMSatisIslemleri = new();
                fRMSatisIslemleri.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Satış işlemleri ekranı açılırken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnMusteriIslemleri_Click(object sender, EventArgs e)
        {
            try
            {
                FRMMusteriIslemleri fRMMusteriIslemleri = new();
                fRMMusteriIslemleri.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri işlemleri ekranı açılırken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
