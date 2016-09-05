using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text= textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bytw_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 to 255");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-128 to 127");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-32,768 to 32,767");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 to 65,535");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-2,147,483,648 to 2,147,483,647");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 to 4,294,967,295");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("–9,223,372,036,854,775,808 to 9,223,372,036,854,775,807");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 to 18, 446, 744, 073, 709, 551, 615");
        }
    }
}
