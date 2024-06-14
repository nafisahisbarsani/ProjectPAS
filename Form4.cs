using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectPAS
{
    public partial class Form4 : Form
    {

        // Deklarasikan SqlConnection dan DataTable di tingkat kelas
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=daftarpasien;Integrated Security=True;");
        DataTable dt = new DataTable();
        public Form4()
        {
            InitializeComponent();
        }
        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("SELECT  nama, umur, alamat, jeniskelamin, dokter, tanggal FROM daftarpasien", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 balik = new Form2();
            balik.Show();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(txtUmur.Text) || string.IsNullOrWhiteSpace(txtAlamat.Text) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Mohon lengkapi semua kolom sebelum menambahkan data.");
                return;
            }

            string jeniskelamin = radioButton1.Checked ? "Laki-Laki" : "Perempuan";
            SqlCommand cmd2 = new SqlCommand("INSERT INTO daftarpasien(nama, umur, alamat, jeniskelamin, dokter, tanggal) VALUES(@nama, @umur, @alamat, @jeniskelamin, @dokter, @tanggal)", conn);
            cmd2.Parameters.AddWithValue("nama", txtNama.Text);
            cmd2.Parameters.AddWithValue("umur", int.Parse(txtUmur.Text));
            cmd2.Parameters.AddWithValue("alamat", txtAlamat.Text);
            cmd2.Parameters.AddWithValue("jeniskelamin", jeniskelamin);
            cmd2.Parameters.AddWithValue("dokter", comboBox1.SelectedItem.ToString());
            cmd2.Parameters.AddWithValue("tanggal", dateTimePicker1.Value.Date);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            txtNama.Text = selectedRow.Cells[0].Value.ToString();
            txtUmur.Text = selectedRow.Cells[1].Value.ToString();
            txtAlamat.Text = selectedRow.Cells[2].Value.ToString();
            string jeniskelamin = selectedRow.Cells[3].Value.ToString();
            if (jeniskelamin == "Laki-Laki")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            comboBox1.SelectedItem = selectedRow.Cells[4].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(selectedRow.Cells[5].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama tidak boleh kosong. Silakan isi nama sebelum menghapus data.");
                return;
            }

            DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=daftarpasien;Integrated Security=True"))
                {
                    conn.Open();

                    SqlCommand cmd4 = new SqlCommand("DELETE FROM daftarpasien WHERE nama=@nama", conn);
                    cmd4.Parameters.AddWithValue("@nama", txtNama.Text);

                    int rowsAffected = cmd4.ExecuteNonQuery();
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


        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                txtNama.Clear();
                txtUmur.Clear();
                txtAlamat.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                comboBox1.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Now;
                MessageBox.Show("Data telah dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Penghapusan data dibatalkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda ingin mengupdate?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string jeniskelamin = radioButton1.Checked ? "Laki-Laki" : "Perempuan";
                SqlCommand cmd3 = new SqlCommand("UPDATE daftarpasien SET  nama=@nama, alamat=@alamat, jeniskelamin=@jeniskelamin, dokter=@dokter, tanggal=@tanggal WHERE umur=@umur", conn);
                cmd3.Parameters.AddWithValue("nama", txtNama.Text);
                cmd3.Parameters.AddWithValue("umur", int.Parse(txtUmur.Text));
                cmd3.Parameters.AddWithValue("alamat", txtAlamat.Text);
                cmd3.Parameters.AddWithValue("jeniskelamin", jeniskelamin);
                cmd3.Parameters.AddWithValue("dokter", comboBox1.SelectedItem.ToString());
                cmd3.Parameters.AddWithValue("tanggal", dateTimePicker1.Value.Date);
                conn.Open();
                cmd3.ExecuteNonQuery();
                conn.Close();
                bind_data();
                MessageBox.Show("Data telah diupdate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update dibatalkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string printContent = "Nama: " + selectedRow.Cells["nama"].Value.ToString() + "\n" +
                                      "Umur: " + selectedRow.Cells["umur"].Value.ToString() + "\n" +
                                      "Alamat: " + selectedRow.Cells["alamat"].Value.ToString() + "\n" +
                                      "Jenis Kelamin: " + selectedRow.Cells["jeniskelamin"].Value.ToString() + "\n" +
                                      "Dokter: " + selectedRow.Cells["dokter"].Value.ToString() + "\n" +
                                      "Tanggal: " + DateTime.Parse(selectedRow.Cells["tanggal"].Value.ToString()).ToString("dd/MM/yyyy");

                Font printFont = new Font("Arial", 12);

                e.Graphics.DrawString(printContent, printFont, Brushes.Black, new PointF(10, 10));
            }
            else
            {

                e.Graphics.DrawString("No data selected.", new Font("Arial", 12), Brushes.Black, new PointF(10, 10));
            }
        }


        private void btnPrint_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Pilih baris data terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUmur_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            bind_data();
        }
    }
}

