using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPAS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 balik = new Form1();
            balik.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 baru = new Form3();
            baru.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4 baru = new Form4();
            baru.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5 baru = new Form5();
            baru.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
