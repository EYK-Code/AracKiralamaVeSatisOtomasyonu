namespace AracKiralamaVeSatisOtomasyonu.UI
{
    partial class FRMMusteriIslemleri
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtMusteriTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMusteriEmail;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtMusteriAdres;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvMusteriler;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMusteriIslemleri));
            lblAdSoyad = new Label();
            txtMusteriAdSoyad = new TextBox();
            lblTelefon = new Label();
            txtMusteriTelefon = new TextBox();
            lblEmail = new Label();
            txtMusteriEmail = new TextBox();
            lblAdres = new Label();
            txtMusteriAdres = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            dgvMusteriler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.ForeColor = Color.FromArgb(33, 33, 33);
            lblAdSoyad.Location = new Point(22, 37);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(152, 23);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "Müşteri Adı Soyadı";
            lblAdSoyad.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMusteriAdSoyad
            // 
            txtMusteriAdSoyad.Font = new Font("Segoe UI", 9F);
            txtMusteriAdSoyad.Location = new Point(180, 29);
            txtMusteriAdSoyad.Margin = new Padding(3, 5, 3, 5);
            txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            txtMusteriAdSoyad.Size = new Size(200, 27);
            txtMusteriAdSoyad.TabIndex = 1;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.ForeColor = Color.FromArgb(33, 33, 33);
            lblTelefon.Location = new Point(22, 86);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(136, 23);
            lblTelefon.TabIndex = 2;
            lblTelefon.Text = "Müşteri Telefonu";
            lblTelefon.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMusteriTelefon
            // 
            txtMusteriTelefon.Font = new Font("Segoe UI", 9F);
            txtMusteriTelefon.Location = new Point(180, 86);
            txtMusteriTelefon.Margin = new Padding(3, 5, 3, 5);
            txtMusteriTelefon.MaxLength = 11;
            txtMusteriTelefon.Name = "txtMusteriTelefon";
            txtMusteriTelefon.Size = new Size(200, 27);
            txtMusteriTelefon.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.ForeColor = Color.FromArgb(33, 33, 33);
            lblEmail.Location = new Point(22, 144);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(140, 23);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Müşteri E-Postası";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMusteriEmail
            // 
            txtMusteriEmail.Font = new Font("Segoe UI", 9F);
            txtMusteriEmail.Location = new Point(180, 144);
            txtMusteriEmail.Margin = new Padding(3, 5, 3, 5);
            txtMusteriEmail.Name = "txtMusteriEmail";
            txtMusteriEmail.Size = new Size(200, 27);
            txtMusteriEmail.TabIndex = 5;
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.ForeColor = Color.FromArgb(33, 33, 33);
            lblAdres.Location = new Point(22, 201);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(119, 23);
            lblAdres.TabIndex = 6;
            lblAdres.Text = "Müşteri Adresi";
            lblAdres.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMusteriAdres
            // 
            txtMusteriAdres.Font = new Font("Segoe UI", 9F);
            txtMusteriAdres.Location = new Point(180, 198);
            txtMusteriAdres.Margin = new Padding(3, 5, 3, 5);
            txtMusteriAdres.Name = "txtMusteriAdres";
            txtMusteriAdres.Size = new Size(200, 27);
            txtMusteriAdres.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(144, 202, 249);
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(22, 291);
            btnEkle.Margin = new Padding(3, 5, 3, 5);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(90, 40);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(144, 202, 249);
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(142, 291);
            btnSil.Margin = new Padding(3, 5, 3, 5);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(90, 40);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(144, 202, 249);
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(261, 291);
            btnGuncelle.Margin = new Padding(3, 5, 3, 5);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(90, 40);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.GridColor = Color.LightGray;
            dgvMusteriler.Location = new Point(14, 344);
            dgvMusteriler.Margin = new Padding(3, 5, 3, 5);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersVisible = false;
            dgvMusteriler.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dgvMusteriler.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMusteriler.RowTemplate.Height = 24;
            dgvMusteriler.Size = new Size(855, 288);
            dgvMusteriler.TabIndex = 11;
            dgvMusteriler.CellClick += dgvMusteriler_CellClick;
            // 
            // FRMMusteriIslemleri
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 646);
            Controls.Add(lblAdSoyad);
            Controls.Add(txtMusteriAdSoyad);
            Controls.Add(lblTelefon);
            Controls.Add(txtMusteriTelefon);
            Controls.Add(lblEmail);
            Controls.Add(txtMusteriEmail);
            Controls.Add(lblAdres);
            Controls.Add(txtMusteriAdres);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(dgvMusteriler);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            Name = "FRMMusteriIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri İşlemleri";
            Load += FRMMusteriIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
