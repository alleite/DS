using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anaLuizaLeiteAlvesRosario
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

        private void btn_result_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, md;
            n1 = double.Parse(txt_n1.Text);
            n2 = double.Parse(txt_n2.Text);
            n3 = double.Parse(txt_n3.Text);
            n4 = double.Parse(txt_n4.Text);

            md = (n1 + n2 + n3 + n4) / 4;

            if(md >= 0 && md <= 5){
                lbl_result.Text = "A média é I";
                lbl_result.ForeColor = Color.Red;
            }
            else if (md >= 5.1 && md <= 7)
            {
                lbl_result.Text = "A média é R";
                lbl_result.ForeColor = Color.OrangeRed;
            }
            else if ( md >= 7.1 && md <= 9)
            {
                lbl_result.Text = "A média é B";
                lbl_result.ForeColor = Color.AliceBlue;
            }
            else if (md >= 9.1 && md <= 10)
            {
                lbl_result.Text = "A média é MB";
                lbl_result.ForeColor = Color.Blue;
            }
        }
    }
}
