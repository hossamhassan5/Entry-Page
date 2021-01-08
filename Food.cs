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
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Select();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this food");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this food");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this food");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this food");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this food");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this food");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this food");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this food");
        }
    }
}
