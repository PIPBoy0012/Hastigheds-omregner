using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastigheds_omregner
{
    public partial class Form1 : Form
    {
        private Regner omregneren = new Regner();

        public int kmt = 0;

        public int ms = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kmtCombobox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                kmt = Int32.Parse(kmtCombobox.Text);
            }
            catch
            {
                kmt = 0;
            }
        }

        private void msCombobox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ms = Int32.Parse(msCombobox.Text);
            }
            catch
            {
                ms = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox2.Text = omregneren.kmtregning(kmt).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = omregneren.msregning(ms).ToString();
        }
    }
}
