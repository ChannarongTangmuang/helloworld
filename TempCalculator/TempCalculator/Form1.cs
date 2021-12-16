using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempCalculator
{
    public partial class buttonConvert : Form
    {
        public buttonConvert()
        {
            InitializeComponent();
        }

        private void textBoxF_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get input from textbox
            string input = textBoxC.Text;
            // f= c * 9/5 + 32
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;
           
            // show input to textbox
            textBoxF.Text = f.ToString();
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string input = textBoxF.Text;
            double f = Convert.ToDouble(input);
            double c = (f - 32) * 5 / 9;
            textBoxC.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
        }
    }
}
