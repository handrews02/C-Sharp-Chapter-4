using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckCredit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            int price;
            price = Convert.ToInt32(txtPrice.Text);

            if (price > 5000)
            {
                lblCheckCredit.Text = "DENIED";
            }
            else if (price <= 5000)
            {
                lblCheckCredit.Text = "APPROVED";
            }
        }
    }
}
