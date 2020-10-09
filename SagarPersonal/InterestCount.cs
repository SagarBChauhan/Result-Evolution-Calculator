using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SagarPersonal
{
    public partial class InterestCount : Form
    {
        int amount, interest ;
        int inte=0;
        int year=0,month=0;
        public InterestCount()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            amount = Convert.ToInt32(TxtAmt.Text);
            interest = Convert.ToInt32(TxtIntPer.Text);
         /*   if (year != null)
            {
                year = Convert.ToInt32(TxtYear.Text);
                year = year * 12;
            }*/

            month=Convert.ToInt32(ComboMonth.Text);
            month=month+year;
           // MessageBox.Show("amount:" + amount);
            //MessageBox.Show("int:" + interest);
            //MessageBox.Show("month:" + month);
            for (int i=0;i<month;i++)
            {
               
                inte = amount / 100 * interest;
                amount = amount + inte;
               // MessageBox.Show("amount:"+amount);
            }

            MessageBox.Show("intersest:"+inte+"\namount:" + amount);
        }
    }
}
