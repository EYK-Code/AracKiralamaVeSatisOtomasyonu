namespace AracKiralamaVeSatisOtomasyonu.UI
{
    partial class FRMAnaEkran
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnAraclar;
        private System.Windows.Forms.Button btnKiralamaIslemleri;
        private System.Windows.Forms.Button btnSatisIslemleri;
        private System.Windows.Forms.Button btnMusteriIslemleri;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAnaEkran));
            btnAraclar = new Button();
            btnKiralamaIslemleri = new Button();
            btnSatisIslemleri = new Button();
            btnMusteriIslemleri = new Button();
            lblBaslik = new Label();
            SuspendLayout();
            // 
            // btnAraclar
            // 
            btnAraclar.Anchor = AnchorStyles.None;
            btnAraclar.BackColor = Color.LightSteelBlue;
            btnAraclar.Cursor = Cursors.Hand;
            btnAraclar.FlatAppearance.BorderSize = 0;
            btnAraclar.FlatStyle = FlatStyle.Flat;
            btnAraclar.ForeColor = Color.Black;
            btnAraclar.Location = new Point(14, 80);
            btnAraclar.Margin = new Padding(3, 5, 3, 5);
            btnAraclar.Name = "btnAraclar";
            btnAraclar.Size = new Size(160, 50);
            btnAraclar.TabIndex = 0;
            btnAraclar.Text = "Araç İşlemleri";
            btnAraclar.UseVisualStyleBackColor = false;
            btnAraclar.Click += btnAraclar_Click;
            // 
            // btnKiralamaIslemleri
            // 
            btnKiralamaIslemleri.Anchor = AnchorStyles.None;
            btnKiralamaIslemleri.BackColor = Color.LightSteelBlue;
            btnKiralamaIslemleri.Cursor = Cursors.Hand;
            btnKiralamaIslemleri.FlatAppearance.BorderSize = 0;
            btnKiralamaIslemleri.FlatStyle = FlatStyle.Flat;
            btnKiralamaIslemleri.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKiralamaIslemleri.ForeColor = Color.Black;
            btnKiralamaIslemleri.Location = new Point(225, 80);
            btnKiralamaIslemleri.Margin = new Padding(3, 5, 3, 5);
            btnKiralamaIslemleri.Name = "btnKiralamaIslemleri";
            btnKiralamaIslemleri.Size = new Size(160, 50);
            btnKiralamaIslemleri.TabIndex = 1;
            btnKiralamaIslemleri.Text = "Kiralama İşlemleri";
            btnKiralamaIslemleri.UseVisualStyleBackColor = false;
            btnKiralamaIslemleri.Click += btnKiralamaIslemleri_Click;
            // 
            // btnSatisIslemleri
            // 
            btnSatisIslemleri.Anchor = AnchorStyles.None;
            btnSatisIslemleri.BackColor = Color.LightSteelBlue;
            btnSatisIslemleri.Cursor = Cursors.Hand;
            btnSatisIslemleri.FlatAppearance.BorderSize = 0;
            btnSatisIslemleri.FlatStyle = FlatStyle.Flat;
            btnSatisIslemleri.ForeColor = Color.Black;
            btnSatisIslemleri.Location = new Point(14, 150);
            btnSatisIslemleri.Margin = new Padding(3, 5, 3, 5);
            btnSatisIslemleri.Name = "btnSatisIslemleri";
            btnSatisIslemleri.Size = new Size(160, 50);
            btnSatisIslemleri.TabIndex = 2;
            btnSatisIslemleri.Text = "Satış İşlemleri";
            btnSatisIslemleri.UseVisualStyleBackColor = false;
            btnSatisIslemleri.Click += btnSatisIslemleri_Click;
            // 
            // btnMusteriIslemleri
            // 
            btnMusteriIslemleri.Anchor = AnchorStyles.None;
            btnMusteriIslemleri.BackColor = Color.LightSteelBlue;
            btnMusteriIslemleri.Cursor = Cursors.Hand;
            btnMusteriIslemleri.FlatAppearance.BorderSize = 0;
            btnMusteriIslemleri.FlatStyle = FlatStyle.Flat;
            btnMusteriIslemleri.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnMusteriIslemleri.ForeColor = Color.Black;
            btnMusteriIslemleri.Location = new Point(225, 150);
            btnMusteriIslemleri.Margin = new Padding(3, 5, 3, 5);
            btnMusteriIslemleri.Name = "btnMusteriIslemleri";
            btnMusteriIslemleri.Size = new Size(160, 50);
            btnMusteriIslemleri.TabIndex = 3;
            btnMusteriIslemleri.Text = "Müşteri İşlemleri";
            btnMusteriIslemleri.UseVisualStyleBackColor = false;
            btnMusteriIslemleri.Click += btnMusteriIslemleri_Click;
            // 
            // lblBaslik
            // 
            lblBaslik.Dock = DockStyle.Top;
            lblBaslik.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBaslik.ForeColor = Color.DarkBlue;
            lblBaslik.Location = new Point(0, 0);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(488, 46);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Araç Kiralama ve Satış Otomasyonu";
            lblBaslik.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FRMAnaEkran
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(488, 230);
            Controls.Add(lblBaslik);
            Controls.Add(btnAraclar);
            Controls.Add(btnKiralamaIslemleri);
            Controls.Add(btnSatisIslemleri);
            Controls.Add(btnMusteriIslemleri);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            Name = "FRMAnaEkran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Ekran";
            ResumeLayout(false);
        }
        private Label lblBaslik;
    }
}

