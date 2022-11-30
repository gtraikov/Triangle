using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a=double.Parse(textBox1.Text);
            double ha=double.Parse(textBox2.Text);
            double S = a * ha / 2;
            label3.Text = "Лицето на триъгълника е: "+S.ToString();
        }
    }
}
