using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahrenheitToCelsiusConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            double temp1;
            double temp2;
            double temp3;
            double conversion1;
            double conversion2;
            double conversion3;

            temp1 = Convert.ToDouble(txtTemp1.Text);
            temp2 = Convert.ToDouble(txtTemp2.Text);
            temp3 = Convert.ToDouble(txtTemp3.Text);

            conversion1 = (temp1 - 32) * (5 / 9);
            conversion2 = (temp2 - 32) * (5 / 9);
            conversion3 = (temp3 - 32) * (5 / 9);

            if(conversion1 < 32)
            {
                lblConversion1.Text = "Freezing";
            }
            if (conversion1 > 32)
            {
                lblConversion1.Text = "It is hot outside";
            }
            if (conversion2 < 32)
            {
                lblConversion1.Text = "Freezing";
            }
            if (conversion2 > 32)
            {
                lblConversion1.Text = "It is hot outside";
            }
        }
    }
}
