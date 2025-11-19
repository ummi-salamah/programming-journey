namespace ProjekAkhir_UMMISALAMAH_XPPLG2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblJudul = new Label();
            lblJenisKebab = new Label();
            lblHarga = new Label();
            lblJumlahBeli = new Label();
            lblUangBayar = new Label();
            cmbKebab = new ComboBox();
            txtBayar = new TextBox();
            txtJumlahBeli = new TextBox();
            lblTotalBayar = new Label();
            txtTotal = new TextBox();
            txtHarga = new TextBox();
            btnHitung = new Button();
            btnHapus = new Button();
            btnKeluar = new Button();
            Kembalian = new Label();
            txtKembalian = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(172, 18);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(255, 45);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "KEBAB RAMAH\r\n";
            // 
            // lblJenisKebab
            // 
            lblJenisKebab.AutoSize = true;
            lblJenisKebab.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJenisKebab.Location = new Point(34, 129);
            lblJenisKebab.Name = "lblJenisKebab";
            lblJenisKebab.Size = new Size(155, 28);
            lblJenisKebab.TabIndex = 1;
            lblJenisKebab.Text = "Jenis Kebab    : ";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(34, 210);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(151, 28);
            lblHarga.TabIndex = 2;
            lblHarga.Text = "Harga(Rp)       :";
            // 
            // lblJumlahBeli
            // 
            lblJumlahBeli.AutoSize = true;
            lblJumlahBeli.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahBeli.Location = new Point(34, 289);
            lblJumlahBeli.Name = "lblJumlahBeli";
            lblJumlahBeli.Size = new Size(150, 25);
            lblJumlahBeli.TabIndex = 3;
            lblJumlahBeli.Text = "Jumlah Beli        :";
            // 
            // lblUangBayar
            // 
            lblUangBayar.AutoSize = true;
            lblUangBayar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUangBayar.Location = new Point(34, 372);
            lblUangBayar.Name = "lblUangBayar";
            lblUangBayar.Size = new Size(150, 28);
            lblUangBayar.TabIndex = 4;
            lblUangBayar.Text = "Uang Bayar     :";
            // 
            // cmbKebab
            // 
            cmbKebab.FormattingEnabled = true;
            cmbKebab.Items.AddRange(new object[] { "Kebab Ayam", "Kebab Sapi", "Kebab Spesial", "Kebab Sayur", "Kebab Keju Mozarella" });
            cmbKebab.Location = new Point(195, 129);
            cmbKebab.Name = "cmbKebab";
            cmbKebab.Size = new Size(182, 33);
            cmbKebab.TabIndex = 5;
            cmbKebab.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtBayar
            // 
            txtBayar.Location = new Point(195, 372);
            txtBayar.Name = "txtBayar";
            txtBayar.Size = new Size(182, 31);
            txtBayar.TabIndex = 7;
            txtBayar.TextChanged += txtBayar_TextChanged;
            // 
            // txtJumlahBeli
            // 
            txtJumlahBeli.Location = new Point(195, 289);
            txtJumlahBeli.Name = "txtJumlahBeli";
            txtJumlahBeli.Size = new Size(43, 31);
            txtJumlahBeli.TabIndex = 8;
            txtJumlahBeli.TextChanged += txtJumlhBeli_TextChanged;
            // 
            // lblTotalBayar
            // 
            lblTotalBayar.AutoSize = true;
            lblTotalBayar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBayar.Location = new Point(34, 455);
            lblTotalBayar.Name = "lblTotalBayar";
            lblTotalBayar.Size = new Size(151, 28);
            lblTotalBayar.TabIndex = 9;
            lblTotalBayar.Text = "Total Bayar      :";
            lblTotalBayar.Click += lblTotalBayar_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(195, 452);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(182, 31);
            txtTotal.TabIndex = 10;
            txtTotal.TextChanged += tb_TextChanged;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(195, 210);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(182, 31);
            txtHarga.TabIndex = 11;
            // 
            // btnHitung
            // 
            btnHitung.BackColor = Color.SeaGreen;
            btnHitung.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHitung.Location = new Point(34, 628);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(112, 39);
            btnHitung.TabIndex = 12;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = false;
            btnHitung.Click += btnHitung_Click;
            // 
            // btnHapus
            // 
            btnHapus.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.Location = new Point(230, 628);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 39);
            btnHapus.TabIndex = 13;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Red;
            btnKeluar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeluar.Location = new Point(431, 628);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(112, 39);
            btnKeluar.TabIndex = 14;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // Kembalian
            // 
            Kembalian.AutoSize = true;
            Kembalian.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Kembalian.Location = new Point(34, 527);
            Kembalian.Name = "Kembalian";
            Kembalian.Size = new Size(154, 28);
            Kembalian.TabIndex = 15;
            Kembalian.Text = " Kembalian      :";
            // 
            // txtKembalian
            // 
            txtKembalian.Location = new Point(195, 524);
            txtKembalian.Name = "txtKembalian";
            txtKembalian.Size = new Size(182, 31);
            txtKembalian.TabIndex = 16;
            txtKembalian.TextChanged += txtKembalian_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(383, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 63);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 18;
            label1.Text = "Ummi Salamah";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(606, 732);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtKembalian);
            Controls.Add(Kembalian);
            Controls.Add(btnKeluar);
            Controls.Add(btnHapus);
            Controls.Add(btnHitung);
            Controls.Add(txtHarga);
            Controls.Add(txtTotal);
            Controls.Add(lblTotalBayar);
            Controls.Add(txtJumlahBeli);
            Controls.Add(txtBayar);
            Controls.Add(cmbKebab);
            Controls.Add(lblUangBayar);
            Controls.Add(lblJumlahBeli);
            Controls.Add(lblHarga);
            Controls.Add(lblJenisKebab);
            Controls.Add(lblJudul);
            Name = "Form1";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblJenisKebab;
        private Label lblHarga;
        private Label lblJumlahBeli;
        private Label lblUangBayar;
        private ComboBox cmbKebab;
        private TextBox txtBayar;
        private TextBox txtJumlahBeli;
        private Label lblTotalBayar;
        private TextBox txtTotal;
        private TextBox txtHarga;
        private Button btnHitung;
        private Button btnHapus;
        private Button btnKeluar;
        private Label Kembalian;
        private TextBox txtKembalian;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
