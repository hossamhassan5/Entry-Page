using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entry_Page
{
    public partial class Sweets : Form
    {
        public Sweets()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this sweet");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this sweet");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this sweet");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this sweet");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this sweet");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this sweet");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this sweet");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this sweet");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this sweet");
        }
    }
}
