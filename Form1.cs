using System.Xml.Linq;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ProjectPAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0'; 
            }
            else
            {
                txtPassword.PasswordChar = '*'; 
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda yakin ingin keluar?", "WARNING!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                
                Application.Exit();
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=ProjectPAS;Integrated Security=True;");
            conn.Open();

            string query = "SELECT COUNT(*) FROM dbo.login WHERE username=@username AND password = @password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();

            if ((Application.OpenForms["Form2"] as Form1) == null)
            {
                Form2 baru = new Form2();
                baru.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error Login");
            }

        }
    }
}
