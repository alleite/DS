using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_supermercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            quantidade op = new quantidade();
            int q1 = int.Parse(txt_quant_estq.Text);
            int q2 = int.Parse(txt_quant_max.Text);
            txt_result.Text = "" + op.quant(q1, q2);
        }
    }
}
