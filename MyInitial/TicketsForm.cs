using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class txtAmountDue : Form
    {
        TicketPrice mTicketPrice;
        int mSection = 2;
        int mQuantity = 0;
        bool mDiscount = false;
        int theDiscount = 0;

        public txtAmountDue()
        {
            InitializeComponent();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            mQuantity = int.Parse(txtQuantity.Text);

            if (chkDiscount.Checked)
                { mDiscount = true; }

            if (radBalcony.Checked)
                { mSection = 1; }
            if (radGeneral.Checked)
                { mSection = 2; }
            if (radBox.Checked)
                { mSection = 3; }


            theDiscount = int.Parse(txtDiscount.Text);
            mTicketPrice = new TicketPrice(mSection, mQuantity, mDiscount, theDiscount);

            mTicketPrice.calculatePrice();
            lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text == null) {
               mQuantity = 1;

            }
            else { 
            mQuantity = int.Parse(txtQuantity.Text);
            }
            if (chkDiscount.Checked)
            { mDiscount = true; }

            if (radBalcony.Checked)
            { mSection = 1; }
            if (radGeneral.Checked)
            { mSection = 2; }
            if (radBox.Checked)
            { mSection = 3; }


            theDiscount = int.Parse(txtDiscount.Text);
            mTicketPrice = new TicketPrice(mSection, mQuantity, mDiscount, theDiscount);

            mTicketPrice.calculatePrice();
            lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
        }
    }
}
