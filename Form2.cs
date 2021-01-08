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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have successfully ordered the offer");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Food f = new Food();
            this.Hide();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drinks s = new drinks();
            this.Hide();
            s.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sweets d = new Sweets();
            this.Hide();
            d.ShowDialog();
        }
    }
}
