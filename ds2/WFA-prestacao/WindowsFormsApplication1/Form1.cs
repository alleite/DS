using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            calculo op = new calculo();
            double vprest = double.Parse(txt_vprest.Text);
            double taxa = double.Parse(txt_taxa.Text);
            double tempo = double.Parse(txt_temp.Text);
            txt_prest.Text = " " + op.prestacao(vprest, taxa, tempo);
        }
    }
}
