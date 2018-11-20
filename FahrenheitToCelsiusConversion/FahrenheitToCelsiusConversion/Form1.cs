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
            double temp1;
            double temp2;
            double temp3;
            double conversion1;
            double conversion2;
            double conversion3;
            double average;
        private void btnConversion_Click(object sender, EventArgs e)
        {
        

            temp1 = Convert.ToDouble(txtTemp1.Text);
            temp2 = Convert.ToDouble(txtTemp2.Text);
            temp3 = Convert.ToDouble(txtTemp3.Text);

            conversion1 = (temp1 - 32) * 1.8;
            conversion2 = (temp2 - 32) * 1.8;
            conversion3 = (temp3 - 32) * 1.8;

            if(conversion1 < 32)
            {
                lblConversion1.Text = conversion1 + " degrees celsius, it is Freezing";
            }
            if (conversion1 > 32)
            {
                lblConversion1.Text = conversion1 + " degrees celsius, it is hot outside";
            }
            if (conversion2 < 32)
            {
                lblConversion2.Text = conversion2 + " degrees celsius, it is Freezing";
            }
            if (conversion2 > 32)
            {
                lblConversion2.Text = conversion2 + " degrees celsius, t is hot outside";
            }
            if (conversion3 < 32)
            {
                lblConversion3.Text = conversion3 + " degrees celsius, it is Freezing";
            }
            if (conversion3 > 32)
            {
                lblConversion3.Text = conversion3 + " degrees celsius, t is hot outside";
            }

            lblFahrenheitTitle.Visible = true;

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            temp1 = Convert.ToDouble(txtTemp1.Text);
            temp2 = Convert.ToDouble(txtTemp2.Text);
            temp3 = Convert.ToDouble(txtTemp3.Text);

            average = (temp1 + temp2 + temp3) / 3;

            lblAverage.Text = "The average is " + average;
        }

       
    }
}
