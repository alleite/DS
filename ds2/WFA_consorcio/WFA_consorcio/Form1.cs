using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_consorcio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc op = new calc();
            double prest = double.Parse(txt_prest.Text);
            double prestpagos = double.Parse(txt_prestpagos.Text);
            double vatual = double.Parse(txt_vatual.Text);
            txt_vtotal.Text = "" + op.vtotal(prest, prestpagos, vatual);
            txt_devedor.Text = "" + op.vdeved(prest, prestpagos, vatual);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
