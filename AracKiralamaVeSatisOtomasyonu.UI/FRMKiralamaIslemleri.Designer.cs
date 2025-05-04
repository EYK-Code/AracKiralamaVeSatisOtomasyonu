namespace AracKiralamaVeSatisOtomasyonu.UI
{
    partial class FRMKiralamaIslemleri
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.ComboBox cmbMusteriAdi;
        private System.Windows.Forms.Label lblArac;
        private System.Windows.Forms.ComboBox cmbArac;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label lblGunlukUcret;
        private System.Windows.Forms.NumericUpDown nudGunlukUcret;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.DataGridView dgvKiralamalar;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMKiralamaIslemleri));
            lblMusteriAdi = new Label();
            cmbMusteriAdi = new ComboBox();
            lblArac = new Label();
            cmbArac = new ComboBox();
            lblBaslangicTarihi = new Label();
            dtpBaslangicTarihi = new DateTimePicker();
            lblBitisTarihi = new Label();
            dtpBitisTarihi = new DateTimePicker();
            lblGunlukUcret = new Label();
            nudGunlukUcret = new NumericUpDown();
            btnKirala = new Button();
            dgvKiralamalar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudGunlukUcret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKiralamalar).BeginInit();
            SuspendLayout();
            // 
            // lblMusteriAdi
            // 
            lblMusteriAdi.AutoSize = true;
            lblMusteriAdi.ForeColor = Color.FromArgb(33, 33, 33);
            lblMusteriAdi.Location = new Point(22, 34);
            lblMusteriAdi.Name = "lblMusteriAdi";
            lblMusteriAdi.Size = new Size(97, 23);
            lblMusteriAdi.TabIndex = 0;
            lblMusteriAdi.Text = "Müşteri Adı";
            // 
            // cmbMusteriAdi
            // 
            cmbMusteriAdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteriAdi.Font = new Font("Segoe UI", 9F);
            cmbMusteriAdi.Location = new Point(158, 25);
            cmbMusteriAdi.Margin = new Padding(3, 5, 3, 5);
            cmbMusteriAdi.Name = "cmbMusteriAdi";
            cmbMusteriAdi.Size = new Size(229, 28);
            cmbMusteriAdi.TabIndex = 1;
            // 
            // lblArac
            // 
            lblArac.AutoSize = true;
            lblArac.ForeColor = Color.FromArgb(33, 33, 33);
            lblArac.Location = new Point(22, 95);
            lblArac.Name = "lblArac";
            lblArac.Size = new Size(44, 23);
            lblArac.TabIndex = 2;
            lblArac.Text = "Araç";
            // 
            // cmbArac
            // 
            cmbArac.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArac.Font = new Font("Segoe UI", 9F);
            cmbArac.Location = new Point(158, 86);
            cmbArac.Margin = new Padding(3, 5, 3, 5);
            cmbArac.Name = "cmbArac";
            cmbArac.Size = new Size(229, 28);
            cmbArac.TabIndex = 3;
            // 
            // lblBaslangicTarihi
            // 
            lblBaslangicTarihi.AutoSize = true;
            lblBaslangicTarihi.ForeColor = Color.FromArgb(33, 33, 33);
            lblBaslangicTarihi.Location = new Point(22, 152);
            lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            lblBaslangicTarihi.Size = new Size(126, 23);
            lblBaslangicTarihi.TabIndex = 4;
            lblBaslangicTarihi.Text = "Başlangıç Tarihi";
            // 
            // dtpBaslangicTarihi
            // 
            dtpBaslangicTarihi.Font = new Font("Segoe UI", 9F);
            dtpBaslangicTarihi.Location = new Point(158, 144);
            dtpBaslangicTarihi.Margin = new Padding(3, 5, 3, 5);
            dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            dtpBaslangicTarihi.Size = new Size(229, 27);
            dtpBaslangicTarihi.TabIndex = 5;
            // 
            // lblBitisTarihi
            // 
            lblBitisTarihi.AutoSize = true;
            lblBitisTarihi.ForeColor = Color.FromArgb(33, 33, 33);
            lblBitisTarihi.Location = new Point(22, 209);
            lblBitisTarihi.Name = "lblBitisTarihi";
            lblBitisTarihi.Size = new Size(86, 23);
            lblBitisTarihi.TabIndex = 6;
            lblBitisTarihi.Text = "Bitiş Tarihi";
            // 
            // dtpBitisTarihi
            // 
            dtpBitisTarihi.Font = new Font("Segoe UI", 9F);
            dtpBitisTarihi.Location = new Point(158, 201);
            dtpBitisTarihi.Margin = new Padding(3, 5, 3, 5);
            dtpBitisTarihi.Name = "dtpBitisTarihi";
            dtpBitisTarihi.Size = new Size(229, 27);
            dtpBitisTarihi.TabIndex = 7;
            // 
            // lblGunlukUcret
            // 
            lblGunlukUcret.AutoSize = true;
            lblGunlukUcret.ForeColor = Color.FromArgb(33, 33, 33);
            lblGunlukUcret.Location = new Point(22, 267);
            lblGunlukUcret.Name = "lblGunlukUcret";
            lblGunlukUcret.Size = new Size(110, 23);
            lblGunlukUcret.TabIndex = 8;
            lblGunlukUcret.Text = "Günlük Ücret";
            // 
            // nudGunlukUcret
            // 
            nudGunlukUcret.DecimalPlaces = 2;
            nudGunlukUcret.Font = new Font("Segoe UI", 9F);
            nudGunlukUcret.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            nudGunlukUcret.Location = new Point(158, 263);
            nudGunlukUcret.Margin = new Padding(3, 6, 3, 6);
            nudGunlukUcret.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudGunlukUcret.Name = "nudGunlukUcret";
            nudGunlukUcret.Size = new Size(229, 27);
            nudGunlukUcret.TabIndex = 9;
            nudGunlukUcret.ThousandsSeparator = true;
            // 
            // btnKirala
            // 
            btnKirala.BackColor = Color.SteelBlue;
            btnKirala.Cursor = Cursors.Hand;
            btnKirala.FlatAppearance.BorderSize = 0;
            btnKirala.FlatStyle = FlatStyle.Flat;
            btnKirala.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKirala.ForeColor = Color.White;
            btnKirala.Location = new Point(158, 329);
            btnKirala.Margin = new Padding(3, 5, 3, 5);
            btnKirala.Name = "btnKirala";
            btnKirala.Size = new Size(130, 45);
            btnKirala.TabIndex = 12;
            btnKirala.Text = "Kirala";
            btnKirala.UseVisualStyleBackColor = false;
            btnKirala.Click += btnKirala_Click;
            // 
            // dgvKiralamalar
            // 
            dgvKiralamalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKiralamalar.BackgroundColor = Color.White;
            dgvKiralamalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKiralamalar.GridColor = Color.Gainsboro;
            dgvKiralamalar.Location = new Point(14, 406);
            dgvKiralamalar.Margin = new Padding(3, 5, 3, 5);
            dgvKiralamalar.Name = "dgvKiralamalar";
            dgvKiralamalar.RowHeadersVisible = false;
            dgvKiralamalar.RowHeadersWidth = 51;
            dgvKiralamalar.RowTemplate.Height = 24;
            dgvKiralamalar.Size = new Size(855, 288);
            dgvKiralamalar.TabIndex = 13;
            // 
            // FRMKiralamaIslemleri
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 708);
            Controls.Add(lblMusteriAdi);
            Controls.Add(cmbMusteriAdi);
            Controls.Add(lblArac);
            Controls.Add(cmbArac);
            Controls.Add(lblBaslangicTarihi);
            Controls.Add(dtpBaslangicTarihi);
            Controls.Add(lblBitisTarihi);
            Controls.Add(dtpBitisTarihi);
            Controls.Add(lblGunlukUcret);
            Controls.Add(nudGunlukUcret);
            Controls.Add(btnKirala);
            Controls.Add(dgvKiralamalar);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            Name = "FRMKiralamaIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kiralama İşlemleri";
            Load += FRMKiralamaIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)nudGunlukUcret).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKiralamalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
