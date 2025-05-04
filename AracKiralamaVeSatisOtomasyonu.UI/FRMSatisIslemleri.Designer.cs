namespace AracKiralamaVeSatisOtomasyonu.UI
{
    partial class FRMSatisIslemleri
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.ComboBox cmbMusteriAdi;
        private System.Windows.Forms.Label lblOdemeTuru;
        private System.Windows.Forms.ComboBox cmbOdemeTuru;
        private System.Windows.Forms.Label lblArac;
        private System.Windows.Forms.ComboBox cmbArac;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.DataGridView dgvSatislar;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMSatisIslemleri));
            lblMusteriAdi = new Label();
            cmbMusteriAdi = new ComboBox();
            lblOdemeTuru = new Label();
            cmbOdemeTuru = new ComboBox();
            lblArac = new Label();
            cmbArac = new ComboBox();
            lblFiyat = new Label();
            nudFiyat = new NumericUpDown();
            btnSatisYap = new Button();
            dgvSatislar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSatislar).BeginInit();
            SuspendLayout();
            // 
            // lblMusteriAdi
            // 
            lblMusteriAdi.AutoSize = true;
            lblMusteriAdi.Font = new Font("Segoe UI", 10F);
            lblMusteriAdi.ForeColor = Color.FromArgb(33, 33, 33);
            lblMusteriAdi.Location = new Point(22, 38);
            lblMusteriAdi.Name = "lblMusteriAdi";
            lblMusteriAdi.Size = new Size(97, 23);
            lblMusteriAdi.TabIndex = 0;
            lblMusteriAdi.Text = "Müşteri Adı";
            // 
            // cmbMusteriAdi
            // 
            cmbMusteriAdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMusteriAdi.Location = new Point(135, 29);
            cmbMusteriAdi.Margin = new Padding(3, 5, 3, 5);
            cmbMusteriAdi.Name = "cmbMusteriAdi";
            cmbMusteriAdi.Size = new Size(200, 31);
            cmbMusteriAdi.TabIndex = 1;
            // 
            // lblOdemeTuru
            // 
            lblOdemeTuru.AutoSize = true;
            lblOdemeTuru.ForeColor = Color.FromArgb(33, 33, 33);
            lblOdemeTuru.Location = new Point(22, 95);
            lblOdemeTuru.Name = "lblOdemeTuru";
            lblOdemeTuru.Size = new Size(106, 23);
            lblOdemeTuru.TabIndex = 2;
            lblOdemeTuru.Text = "Ödeme Türü";
            // 
            // cmbOdemeTuru
            // 
            cmbOdemeTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOdemeTuru.Location = new Point(135, 86);
            cmbOdemeTuru.Margin = new Padding(3, 5, 3, 5);
            cmbOdemeTuru.Name = "cmbOdemeTuru";
            cmbOdemeTuru.Size = new Size(200, 31);
            cmbOdemeTuru.TabIndex = 3;
            // 
            // lblArac
            // 
            lblArac.AutoSize = true;
            lblArac.ForeColor = Color.FromArgb(33, 33, 33);
            lblArac.Location = new Point(24, 153);
            lblArac.Name = "lblArac";
            lblArac.Size = new Size(44, 23);
            lblArac.TabIndex = 4;
            lblArac.Text = "Araç";
            // 
            // cmbArac
            // 
            cmbArac.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArac.Location = new Point(135, 144);
            cmbArac.Margin = new Padding(3, 5, 3, 5);
            cmbArac.Name = "cmbArac";
            cmbArac.Size = new Size(200, 31);
            cmbArac.TabIndex = 5;
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.ForeColor = Color.FromArgb(33, 33, 33);
            lblFiyat.Location = new Point(22, 209);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(45, 23);
            lblFiyat.TabIndex = 6;
            lblFiyat.Text = "Fiyat";
            // 
            // nudFiyat
            // 
            nudFiyat.Location = new Point(135, 202);
            nudFiyat.Margin = new Padding(3, 7, 3, 7);
            nudFiyat.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(200, 30);
            nudFiyat.TabIndex = 7;
            // 
            // btnSatisYap
            // 
            btnSatisYap.BackColor = Color.LightSeaGreen;
            btnSatisYap.Cursor = Cursors.Hand;
            btnSatisYap.FlatAppearance.BorderSize = 0;
            btnSatisYap.FlatStyle = FlatStyle.Flat;
            btnSatisYap.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSatisYap.ForeColor = Color.White;
            btnSatisYap.Location = new Point(135, 259);
            btnSatisYap.Margin = new Padding(3, 5, 3, 5);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(120, 40);
            btnSatisYap.TabIndex = 8;
            btnSatisYap.Text = "Satış Yap";
            btnSatisYap.UseVisualStyleBackColor = false;
            btnSatisYap.Click += btnSatisYap_Click;
            // 
            // dgvSatislar
            // 
            dgvSatislar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSatislar.BackgroundColor = Color.White;
            dgvSatislar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSatislar.GridColor = Color.LightGray;
            dgvSatislar.Location = new Point(22, 331);
            dgvSatislar.Margin = new Padding(3, 5, 3, 5);
            dgvSatislar.Name = "dgvSatislar";
            dgvSatislar.RowHeadersVisible = false;
            dgvSatislar.RowHeadersWidth = 51;
            dgvSatislar.RowTemplate.Height = 24;
            dgvSatislar.Size = new Size(855, 288);
            dgvSatislar.TabIndex = 9;
            // 
            // FRMSatisIslemleri
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 646);
            Controls.Add(lblMusteriAdi);
            Controls.Add(cmbMusteriAdi);
            Controls.Add(lblOdemeTuru);
            Controls.Add(cmbOdemeTuru);
            Controls.Add(lblArac);
            Controls.Add(cmbArac);
            Controls.Add(lblFiyat);
            Controls.Add(nudFiyat);
            Controls.Add(btnSatisYap);
            Controls.Add(dgvSatislar);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            Name = "FRMSatisIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış İşlemleri";
            Load += FRMSatisIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSatislar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
