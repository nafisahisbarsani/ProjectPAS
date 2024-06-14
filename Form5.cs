using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProjectPAS
{
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=datapenjualan;Integrated Security=True;");
        DataTable dt = new DataTable();
        public Form5()
        {
            InitializeComponent();
        }
        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("SELECT  namaproduk, kodestruk, jumlah, harga, total FROM datapenjualan", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 balik = new Form2();
            balik.Show();
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                txtNamaProduk.Text = dataGridView1.Rows[e.RowIndex].Cells["namaproduk"].Value.ToString();
                txtKodeStruk.Text = dataGridView1.Rows[e.RowIndex].Cells["kodestruk"].Value.ToString();
                txtHarga.Text = dataGridView1.Rows[e.RowIndex].Cells["harga"].Value.ToString();
                txtTotal.Text = dataGridView1.Rows[e.RowIndex].Cells["total"].Value.ToString();

                numericUpDown1.Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["jumlah"].Value);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaProduk.Text) || string.IsNullOrWhiteSpace(txtKodeStruk.Text) || numericUpDown1.Value <= 0 || string.IsNullOrWhiteSpace(txtHarga.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                MessageBox.Show("Mohon lengkapi semua kolom sebelum menambahkan data.");
                return;
            }

            string namaProduk = txtNamaProduk.Text;
            string noStruk = txtKodeStruk.Text;
            int jumlah = (int)numericUpDown1.Value;
            int harga = int.Parse(txtHarga.Text);
            int total = int.Parse(txtTotal.Text);

            
            if (IsStrukExists(noStruk))
            {
                MessageBox.Show("Nomor struk sudah digunakan. Gunakan nomor struk yang lain.");
                return;
            }

            SqlCommand cmd2 = new SqlCommand("INSERT INTO datapenjualan(namaproduk, kodestruk, jumlah, harga, total) VALUES(@namaproduk, @kodestruk, @jumlah, @harga, @total)", conn);
            cmd2.Parameters.AddWithValue("namaproduk", namaProduk);
            cmd2.Parameters.AddWithValue("kodestruk", noStruk);
            cmd2.Parameters.AddWithValue("jumlah", jumlah);
            cmd2.Parameters.AddWithValue("harga", harga);
            cmd2.Parameters.AddWithValue("total", total);

            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();

            MessageBox.Show("Data penjualan berhasil ditambahkan.");
        }

        private bool IsStrukExists(string struk)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM datapenjualan WHERE kodestruk = @kodestruk", conn))
            {
                cmd.Parameters.AddWithValue("@kodestruk", struk);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                return count > 0;
            }
        }



        private void btnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHarga.Text) || numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Mohon isi harga dan jumlah produk terlebih dahulu.");
                return;
            }

            if (!int.TryParse(txtHarga.Text, out int harga))
            {
                MessageBox.Show("Harga harus berupa angka yang valid.");
                return;
            }

            int jumlah = (int)numericUpDown1.Value;
            int total = harga * jumlah;

            txtTotal.Text = total.ToString();
        }

        private void txtNoStruk_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtNamaProduk.Clear();
                txtKodeStruk.Clear();
                txtTotal.Clear();
                txtHarga.Clear();
                numericUpDown1.Value = 1;

            }
            else
            {
                MessageBox.Show("Penghapusan data dibatalkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu.");
                return;
            }

            DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string kodeStruk = dataGridView1.SelectedRows[0].Cells["kodestruk"].Value.ToString();

                using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=datapenjualan;Integrated Security=True"))
                {
                    conn.Open();

                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM datapenjualan WHERE kodestruk=@kodeStruk", conn);
                    cmdDelete.Parameters.AddWithValue("@kodeStruk", kodeStruk);

                    int rowsAffected = cmdDelete.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.");
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan.");
                    }

                    bind_data();
                }
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan.");
            }
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang ingin dicetak terlebih dahulu.");
                return;
            }

            string kodeStruk = dataGridView1.SelectedRows[0].Cells["kodestruk"].Value.ToString();
            decimal totalHarga = 0;

            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.PrintPage += (s, ev) =>
            {
                string strukHeader = "STRUK PENJUALAN";
                string strukContent = "";
                decimal totalKeseluruhan = 0;

                Font fontHeader = new Font("Arial", 14, FontStyle.Bold);
                Font fontContent = new Font("Arial", 12);
                float yPos = 100;
                float leftMargin = 50;

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (row.Cells["kodestruk"].Value.ToString() == kodeStruk)
                    {
                        strukContent += "Nama Produk: " + row.Cells["namaproduk"].Value.ToString() + "\n" +
                                        "No Struk: " + row.Cells["kodestruk"].Value.ToString() + "\n" +
                                        "Jumlah: " + row.Cells["jumlah"].Value.ToString() + "\n" +
                                        "Harga: " + row.Cells["harga"].Value.ToString() + "\n" +
                                        "Total: " + row.Cells["total"].Value.ToString() + "\n\n";

                        totalHarga += Convert.ToDecimal(row.Cells["total"].Value);
                    }
                }

                totalKeseluruhan += totalHarga;

                strukContent += "Total Harga: " + totalHarga.ToString("C") + "\n";
                strukContent += "Total Keseluruhan: " + totalKeseluruhan.ToString("C") + "\n";

                ev.Graphics.DrawString(strukHeader, fontHeader, Brushes.Black, leftMargin, yPos);
                yPos += fontHeader.GetHeight();
                ev.Graphics.DrawString(strukContent, fontContent, Brushes.Black, leftMargin, yPos);
            };

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda ingin mengupdate?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(txtNamaProduk.Text) || string.IsNullOrWhiteSpace(txtKodeStruk.Text) || numericUpDown1.Value <= 0 || string.IsNullOrWhiteSpace(txtHarga.Text) || string.IsNullOrWhiteSpace(txtTotal.Text))
                {
                    MessageBox.Show("Mohon lengkapi semua kolom sebelum mengupdate data.");
                    return;
                }

                SqlCommand cmd3 = new SqlCommand("UPDATE datapenjualan SET namaproduk=@namaproduk, jumlah=@jumlah, harga=@harga, total=@total WHERE kodestruk=@kodestruk", conn);
                cmd3.Parameters.AddWithValue("@namaproduk", txtNamaProduk.Text);
                cmd3.Parameters.AddWithValue("@jumlah", (int)numericUpDown1.Value);
                cmd3.Parameters.AddWithValue("@harga", decimal.Parse(txtHarga.Text));
                cmd3.Parameters.AddWithValue("@total", decimal.Parse(txtTotal.Text));
                cmd3.Parameters.AddWithValue("@kodestruk", txtKodeStruk.Text);

                conn.Open();
                cmd3.ExecuteNonQuery();
                conn.Close();
                bind_data();
                MessageBox.Show("Data penjualan telah diupdate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update data penjualan dibatalkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            bind_data();
        }
    }
}

    
