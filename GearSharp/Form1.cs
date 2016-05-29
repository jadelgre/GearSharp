using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GearSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Decimal originalSize;
            if(!decimal.TryParse(inputOriginalSize.Text, out originalSize))
            {
                MessageBox.Show("You must enter a valid original size!");
            }

            Decimal newSize;
            if (!decimal.TryParse(inputNewSize.Text, out newSize))
            {
                MessageBox.Show("You must enter a valid new size!");
            }

            Decimal originalRatio;
            if (!decimal.TryParse(inputRatio.Text, out originalRatio))
            {
                MessageBox.Show("You must enter a valid gear ratio!");
            }
            // (new Size / old size) X original ratio

            Decimal newRatio = (newSize / originalSize) * originalRatio;
            outputNewRatio.Text = newRatio.ToString("#.##"); // Convert to string with 2 decimal places
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputOriginalSize_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            inputOriginalSize.Text = "";
            inputNewSize.Text = "";
            inputRatio.Text = "";
            outputNewRatio.Text = "";
        }
    }
}
