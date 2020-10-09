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
    public partial class Evolution : Form
    {
        double sem1=0, sem2=0, sem3=0, sem4=0, sem5=0, sem6=0, total;//, per;
        public Evolution()
        {
            InitializeComponent();
        }

        private void TxtSem1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sem1 = Convert.ToDouble(TxtSem1.Text);
                sem2 = Convert.ToDouble(TxtSem2.Text);
                sem3 = Convert.ToDouble(TxtSem3.Text);
                sem4 = Convert.ToDouble(TxtSem4.Text);
                sem5 = Convert.ToDouble(TxtSem5.Text);
                sem6 = Convert.ToDouble(TxtSem6.Text);

                total = sem1 + sem2 + sem3 + sem4 + sem5 + sem6;
                float per = float.Parse(total.ToString())/ 6;

                Result.Text = String.Format("{0:0.00}", per);
               
            }
            catch (Exception EX)
            { }
        }

        private void TxtSem6_TabIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
