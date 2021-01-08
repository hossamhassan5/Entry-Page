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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            string q = (textBox1.Text);
            button4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("our phone:   01114320697");
        }

        private void button4_Click(object sender, EventArgs e)
        {
                               
            textBox1.Visible = false;
            MessageBox.Show("Your complain has been submitted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
