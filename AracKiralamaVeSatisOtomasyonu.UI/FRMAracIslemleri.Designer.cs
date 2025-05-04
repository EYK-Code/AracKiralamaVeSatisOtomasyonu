namespace AracKiralamaVeSatisOtomasyonu.UI
{
    partial class FRMAracIslemleri
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtMarkaBilgisi;
        private System.Windows.Forms.TextBox txtModelBilgisi;
        private System.Windows.Forms.NumericUpDown nudYil;
        private System.Windows.Forms.NumericUpDown nudKM;
        private System.Windows.Forms.ComboBox cmbYakitTuru;
        private System.Windows.Forms.ComboBox cmbSanzimanTipi;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.ComboBox cmbMevcutDurum;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbRenk;
        private System.Windows.Forms.Button btnKiraRaporu;
        private System.Windows.Forms.Button btnSatisRaporu;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvAraclar;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAracIslemleri));
            txtMarkaBilgisi = new TextBox();
            txtModelBilgisi = new TextBox();
            nudYil = new NumericUpDown();
            nudKM = new NumericUpDown();
            cmbYakitTuru = new ComboBox();
            cmbSanzimanTipi = new ComboBox();
            cmbDurum = new ComboBox();
            cmbMevcutDurum = new ComboBox();
            cmbKategori = new ComboBox();
            cmbRenk = new ComboBox();
            btnKiraRaporu = new Button();
            btnSatisRaporu = new Button();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            dgvAraclar = new DataGridView();
            lblMarkaBilgisi = new Label();
            lblModelBilgisi = new Label();
            lblYilBilgisi = new Label();
            lblKMBilgisi = new Label();
            lblYakitTuru = new Label();
            lblSanzimanTipi = new Label();
            lblDurum = new Label();
            lblMevcutDurum = new Label();
            lblKategori = new Label();
            lblRenk = new Label();
            btnListele = new Button();
            ((System.ComponentModel.ISupportInitialize)nudYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).BeginInit();
            SuspendLayout();
            // 
            // txtMarkaBilgisi
            // 
            txtMarkaBilgisi.Font = new Font("Segoe UI", 9F);
            txtMarkaBilgisi.Location = new Point(244, 43);
            txtMarkaBilgisi.Margin = new Padding(3, 5, 3, 5);
            txtMarkaBilgisi.Name = "txtMarkaBilgisi";
            txtMarkaBilgisi.Size = new Size(200, 27);
            txtMarkaBilgisi.TabIndex = 0;
            // 
            // txtModelBilgisi
            // 
            txtModelBilgisi.Font = new Font("Segoe UI", 9F);
            txtModelBilgisi.Location = new Point(244, 83);
            txtModelBilgisi.Margin = new Padding(3, 5, 3, 5);
            txtModelBilgisi.Name = "txtModelBilgisi";
            txtModelBilgisi.Size = new Size(200, 27);
            txtModelBilgisi.TabIndex = 1;
            // 
            // nudYil
            // 
            nudYil.Location = new Point(244, 119);
            nudYil.Margin = new Padding(3, 7, 3, 7);
            nudYil.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudYil.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nudYil.Name = "nudYil";
            nudYil.Size = new Size(200, 30);
            nudYil.TabIndex = 2;
            nudYil.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // nudKM
            // 
            nudKM.Location = new Point(244, 161);
            nudKM.Margin = new Padding(3, 5, 3, 5);
            nudKM.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudKM.Name = "nudKM";
            nudKM.Size = new Size(200, 30);
            nudKM.TabIndex = 3;
            // 
            // cmbYakitTuru
            // 
            cmbYakitTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYakitTuru.Font = new Font("Segoe UI", 9F);
            cmbYakitTuru.Location = new Point(244, 204);
            cmbYakitTuru.Margin = new Padding(3, 5, 3, 5);
            cmbYakitTuru.Name = "cmbYakitTuru";
            cmbYakitTuru.Size = new Size(200, 28);
            cmbYakitTuru.TabIndex = 4;
            // 
            // cmbSanzimanTipi
            // 
            cmbSanzimanTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSanzimanTipi.Font = new Font("Segoe UI", 9F);
            cmbSanzimanTipi.Location = new Point(244, 245);
            cmbSanzimanTipi.Margin = new Padding(3, 5, 3, 5);
            cmbSanzimanTipi.Name = "cmbSanzimanTipi";
            cmbSanzimanTipi.Size = new Size(200, 28);
            cmbSanzimanTipi.TabIndex = 5;
            // 
            // cmbDurum
            // 
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.Font = new Font("Segoe UI", 9F);
            cmbDurum.Location = new Point(244, 286);
            cmbDurum.Margin = new Padding(3, 5, 3, 5);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(200, 28);
            cmbDurum.TabIndex = 6;
            cmbDurum.SelectedIndexChanged += cmbDurum_SelectedIndexChanged;
            // 
            // cmbMevcutDurum
            // 
            cmbMevcutDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMevcutDurum.Font = new Font("Segoe UI", 9F);
            cmbMevcutDurum.Location = new Point(244, 328);
            cmbMevcutDurum.Margin = new Padding(3, 5, 3, 5);
            cmbMevcutDurum.Name = "cmbMevcutDurum";
            cmbMevcutDurum.Size = new Size(200, 28);
            cmbMevcutDurum.TabIndex = 7;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Font = new Font("Segoe UI", 9F);
            cmbKategori.Location = new Point(244, 369);
            cmbKategori.Margin = new Padding(3, 5, 3, 5);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(200, 28);
            cmbKategori.TabIndex = 8;
            // 
            // cmbRenk
            // 
            cmbRenk.BackColor = Color.LightGray;
            cmbRenk.Cursor = Cursors.Hand;
            cmbRenk.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRenk.FlatStyle = FlatStyle.Flat;
            cmbRenk.Font = new Font("Segoe UI", 9F);
            cmbRenk.Location = new Point(244, 411);
            cmbRenk.Margin = new Padding(3, 5, 3, 5);
            cmbRenk.Name = "cmbRenk";
            cmbRenk.Size = new Size(100, 28);
            cmbRenk.TabIndex = 9;
            // 
            // btnKiraRaporu
            // 
            btnKiraRaporu.BackColor = Color.LightSteelBlue;
            btnKiraRaporu.Cursor = Cursors.Hand;
            btnKiraRaporu.FlatAppearance.BorderSize = 0;
            btnKiraRaporu.FlatStyle = FlatStyle.Flat;
            btnKiraRaporu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKiraRaporu.Location = new Point(14, 486);
            btnKiraRaporu.Margin = new Padding(3, 5, 3, 5);
            btnKiraRaporu.Name = "btnKiraRaporu";
            btnKiraRaporu.Size = new Size(120, 50);
            btnKiraRaporu.TabIndex = 10;
            btnKiraRaporu.Text = "Kira Raporu";
            btnKiraRaporu.UseVisualStyleBackColor = false;
            btnKiraRaporu.Click += btnKiraRaporu_Click;
            // 
            // btnSatisRaporu
            // 
            btnSatisRaporu.BackColor = Color.LightSteelBlue;
            btnSatisRaporu.Cursor = Cursors.Hand;
            btnSatisRaporu.FlatAppearance.BorderSize = 0;
            btnSatisRaporu.FlatStyle = FlatStyle.Flat;
            btnSatisRaporu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSatisRaporu.Location = new Point(189, 486);
            btnSatisRaporu.Margin = new Padding(3, 5, 3, 5);
            btnSatisRaporu.Name = "btnSatisRaporu";
            btnSatisRaporu.Size = new Size(124, 50);
            btnSatisRaporu.TabIndex = 11;
            btnSatisRaporu.Text = "Satış Raporu";
            btnSatisRaporu.UseVisualStyleBackColor = false;
            btnSatisRaporu.Click += btnSatisRaporu_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LightSteelBlue;
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnEkle.Location = new Point(364, 486);
            btnEkle.Margin = new Padding(3, 5, 3, 5);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(120, 50);
            btnEkle.TabIndex = 12;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.LightSteelBlue;
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSil.Location = new Point(540, 486);
            btnSil.Margin = new Padding(3, 5, 3, 5);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(120, 50);
            btnSil.TabIndex = 13;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightSteelBlue;
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnGuncelle.Location = new Point(716, 486);
            btnGuncelle.Margin = new Padding(3, 5, 3, 5);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(120, 50);
            btnGuncelle.TabIndex = 14;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dgvAraclar
            // 
            dgvAraclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAraclar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAraclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAraclar.GridColor = Color.LightGray;
            dgvAraclar.Location = new Point(14, 553);
            dgvAraclar.Margin = new Padding(3, 5, 3, 5);
            dgvAraclar.Name = "dgvAraclar";
            dgvAraclar.RowHeadersVisible = false;
            dgvAraclar.RowHeadersWidth = 51;
            dgvAraclar.RowTemplate.Height = 24;
            dgvAraclar.Size = new Size(1039, 288);
            dgvAraclar.TabIndex = 15;
            // 
            // lblMarkaBilgisi
            // 
            lblMarkaBilgisi.AutoSize = true;
            lblMarkaBilgisi.Font = new Font("Segoe UI", 9F);
            lblMarkaBilgisi.ForeColor = Color.FromArgb(33, 33, 33);
            lblMarkaBilgisi.Location = new Point(45, 51);
            lblMarkaBilgisi.Name = "lblMarkaBilgisi";
            lblMarkaBilgisi.Size = new Size(94, 20);
            lblMarkaBilgisi.TabIndex = 16;
            lblMarkaBilgisi.Text = "Marka Bilgisi";
            // 
            // lblModelBilgisi
            // 
            lblModelBilgisi.AutoSize = true;
            lblModelBilgisi.Font = new Font("Segoe UI", 9F);
            lblModelBilgisi.ForeColor = Color.FromArgb(33, 33, 33);
            lblModelBilgisi.Location = new Point(45, 91);
            lblModelBilgisi.Name = "lblModelBilgisi";
            lblModelBilgisi.Size = new Size(96, 20);
            lblModelBilgisi.TabIndex = 17;
            lblModelBilgisi.Text = "Model Bilgisi";
            // 
            // lblYilBilgisi
            // 
            lblYilBilgisi.AutoSize = true;
            lblYilBilgisi.Font = new Font("Segoe UI", 9F);
            lblYilBilgisi.ForeColor = Color.FromArgb(33, 33, 33);
            lblYilBilgisi.Location = new Point(45, 131);
            lblYilBilgisi.Name = "lblYilBilgisi";
            lblYilBilgisi.Size = new Size(69, 20);
            lblYilBilgisi.TabIndex = 18;
            lblYilBilgisi.Text = "Yıl Bilgisi";
            // 
            // lblKMBilgisi
            // 
            lblKMBilgisi.AutoSize = true;
            lblKMBilgisi.Font = new Font("Segoe UI", 9F);
            lblKMBilgisi.ForeColor = Color.FromArgb(33, 33, 33);
            lblKMBilgisi.Location = new Point(45, 171);
            lblKMBilgisi.Name = "lblKMBilgisi";
            lblKMBilgisi.Size = new Size(75, 20);
            lblKMBilgisi.TabIndex = 19;
            lblKMBilgisi.Text = "KM Bilgisi";
            // 
            // lblYakitTuru
            // 
            lblYakitTuru.AutoSize = true;
            lblYakitTuru.Font = new Font("Segoe UI", 9F);
            lblYakitTuru.ForeColor = Color.FromArgb(33, 33, 33);
            lblYakitTuru.Location = new Point(43, 213);
            lblYakitTuru.Name = "lblYakitTuru";
            lblYakitTuru.Size = new Size(73, 20);
            lblYakitTuru.TabIndex = 20;
            lblYakitTuru.Text = "Yakıt Türü";
            // 
            // lblSanzimanTipi
            // 
            lblSanzimanTipi.AutoSize = true;
            lblSanzimanTipi.Font = new Font("Segoe UI", 9F);
            lblSanzimanTipi.ForeColor = Color.FromArgb(33, 33, 33);
            lblSanzimanTipi.Location = new Point(45, 254);
            lblSanzimanTipi.Name = "lblSanzimanTipi";
            lblSanzimanTipi.Size = new Size(102, 20);
            lblSanzimanTipi.TabIndex = 21;
            lblSanzimanTipi.Text = "Şanzıman Tipi";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe UI", 9F);
            lblDurum.ForeColor = Color.FromArgb(33, 33, 33);
            lblDurum.Location = new Point(45, 296);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(54, 20);
            lblDurum.TabIndex = 22;
            lblDurum.Text = "Durum";
            // 
            // lblMevcutDurum
            // 
            lblMevcutDurum.AutoSize = true;
            lblMevcutDurum.Font = new Font("Segoe UI", 9F);
            lblMevcutDurum.ForeColor = Color.FromArgb(33, 33, 33);
            lblMevcutDurum.Location = new Point(45, 336);
            lblMevcutDurum.Name = "lblMevcutDurum";
            lblMevcutDurum.Size = new Size(106, 20);
            lblMevcutDurum.TabIndex = 23;
            lblMevcutDurum.Text = "Mevcut Durum";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI", 9F);
            lblKategori.ForeColor = Color.FromArgb(33, 33, 33);
            lblKategori.Location = new Point(45, 378);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(66, 20);
            lblKategori.TabIndex = 24;
            lblKategori.Text = "Kategori";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Font = new Font("Segoe UI", 9F);
            lblRenk.ForeColor = Color.FromArgb(33, 33, 33);
            lblRenk.Location = new Point(45, 420);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(41, 20);
            lblRenk.TabIndex = 25;
            lblRenk.Text = "Renk";
            // 
            // btnListele
            // 
            btnListele.BackColor = Color.LightSteelBlue;
            btnListele.Cursor = Cursors.Hand;
            btnListele.FlatAppearance.BorderSize = 0;
            btnListele.FlatStyle = FlatStyle.Flat;
            btnListele.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnListele.Location = new Point(883, 486);
            btnListele.Margin = new Padding(3, 5, 3, 5);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(170, 50);
            btnListele.TabIndex = 26;
            btnListele.Text = "Tüm Hepsini Getir";
            btnListele.UseVisualStyleBackColor = false;
            btnListele.Click += btnListele_Click;
            // 
            // FRMAracIslemleri
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1127, 849);
            Controls.Add(btnListele);
            Controls.Add(lblRenk);
            Controls.Add(lblKategori);
            Controls.Add(lblMevcutDurum);
            Controls.Add(lblDurum);
            Controls.Add(lblSanzimanTipi);
            Controls.Add(lblYakitTuru);
            Controls.Add(lblKMBilgisi);
            Controls.Add(lblYilBilgisi);
            Controls.Add(lblModelBilgisi);
            Controls.Add(lblMarkaBilgisi);
            Controls.Add(txtMarkaBilgisi);
            Controls.Add(txtModelBilgisi);
            Controls.Add(nudYil);
            Controls.Add(nudKM);
            Controls.Add(cmbYakitTuru);
            Controls.Add(cmbSanzimanTipi);
            Controls.Add(cmbDurum);
            Controls.Add(cmbMevcutDurum);
            Controls.Add(cmbKategori);
            Controls.Add(cmbRenk);
            Controls.Add(btnKiraRaporu);
            Controls.Add(btnSatisRaporu);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(dgvAraclar);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            Name = "FRMAracIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç İşlemleri";
            Load += FRMAracIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)nudYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAraclar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblMarkaBilgisi;
        private Label lblModelBilgisi;
        private Label lblYilBilgisi;
        private Label lblKMBilgisi;
        private Label lblYakitTuru;
        private Label lblSanzimanTipi;
        private Label lblDurum;
        private Label lblMevcutDurum;
        private Label lblKategori;
        private Label lblRenk;
        private Button btnListele;
    }
}
