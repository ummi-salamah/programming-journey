using System.Linq.Expressions;

namespace ProjekAkhir_UMMISALAMAH_XPPLG2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHarga_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbKebab.Text)
            {
                case "Kebab Ayam":
                    txtHarga.Text = "15000";
                    break;
                case "Kebab Sapi":
                    txtHarga.Text = "20000";
                    break;
                case "Kebab Spesial":
                    txtHarga.Text = "25000";
                    break;
                case "Kebab Sayur":
                    txtHarga.Text = "13000";
                    break;
                case "Kebab Keju Mozarella":
                    txtHarga.Text = "22000";
                    break;

            }
        }

        private void txtTotalBayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            //Hitung
            try
            {
                int harga = int.Parse(txtHarga.Text);
                int jumlah = int.Parse(txtJumlahBeli.Text);
                int total = harga * jumlah;
                txtTotal.Text = total.ToString();

                int bayar = int.Parse(txtBayar.Text);
                int kembalian = bayar - total;
                txtKembalian.Text = kembalian.ToString();

                if (kembalian < 0)
                {
                    MessageBox.Show("UANG BAYAR KURANG!!", "PERINGATAN");
                }
                else
                {
                    MessageBox.Show("Terima Kasih Sudah Memesan", "Sukses");
                }
            }
            catch
            {
                MessageBox.Show("Pastikan semua data sudah terisi!!", "Error");
            }
        }

        private void txtJumlhBeli_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            //Bersihkan semua textBox
            txtHarga.Clear();
            txtJumlahBeli.Clear();
            txtBayar.Clear();
            txtTotal.Clear();
            txtKembalian.Clear();

            //Reset ComboBox ke posisi awal
            cmbKebab.SelectedIndex = -1;

            //Fokus kursor ke ComboBox lagi
            cmbKebab.Focus();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTotalBayar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKembalian_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
