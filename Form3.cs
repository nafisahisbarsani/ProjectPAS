using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectPAS
{
    public partial class Form3 : Form
    {
        // Deklarasikan SqlConnection dan DataTable di tingkat kelas
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=dataobat;Integrated Security=True;");
        DataTable dt = new DataTable();
        public Form3()
        {
            InitializeComponent();
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
        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("Select kodeobat, namaobat As namaobat, stok from dataobat", conn);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Insert into dataobat(kodeobat,namaobat,stok)Values(@kodeobat,@namaobat,@stok)", conn);
            cmd2.Parameters.AddWithValue("kodeobat", txtKodeObat.Text);
            cmd2.Parameters.AddWithValue("namaobat", txtNamaObat.Text);
            cmd2.Parameters.AddWithValue("stok", txtStok.Text);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                if (selectedRow.Cells[0].Value != null)
                    txtKodeObat.Text = selectedRow.Cells[0].Value.ToString();
                if (selectedRow.Cells[1].Value != null)
                    txtNamaObat.Text = selectedRow.Cells[1].Value.ToString();
                if (selectedRow.Cells[2].Value != null)
                    txtStok.Text = selectedRow.Cells[2].Value.ToString();
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            bind_data();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Anda yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Hapus data jika pengguna menekan tombol Yes
                txtKodeObat.Clear();
                txtNamaObat.Clear();
                txtStok.Clear();
                txtSearch.Clear();


                MessageBox.Show("Data telah dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Penghapusan data dibatalkan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("apakah anda ingin mengupdate?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd3 = new SqlCommand("Update dataobat set namaobat=@namaobat,stok=@stok where kodeobat=@kodeobat", conn);

                cmd3.Parameters.AddWithValue("namaobat", txtNamaObat.Text);
                cmd3.Parameters.AddWithValue("stok", txtStok.Text); cmd3.Parameters.AddWithValue("kodeobat", txtKodeObat.Text);
                conn.Open();
                cmd3.ExecuteNonQuery();
                conn.Close();
                bind_data();


                MessageBox.Show("Data telah diupdate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data gagal diupdate.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Select kodeobat, namaobat As namaobat, stok from dataobat where namaobat Like @namaobat+'%'", conn);
            cmd1.Parameters.AddWithValue("namaobat", txtSearch.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        
            DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd4 = new SqlCommand("delete from dataobat where kodeobat=@kodeobat", conn);
                cmd4.Parameters.AddWithValue("kodeobat", txtKodeObat.Text);
                conn.Open();
                cmd4.ExecuteNonQuery();
                conn.Close();
                bind_data();
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan.");
            }
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
