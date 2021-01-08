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
    public partial class drinks : Form
    {
        public drinks()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
        }

        private void drinks_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this drink");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this drink");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this drink");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this drink");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this drink");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have successfully order this drink");
        }
    }
}
