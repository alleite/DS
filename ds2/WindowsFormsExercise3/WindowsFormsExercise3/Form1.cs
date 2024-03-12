using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercise3
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, med, p1, p2, p3;
            n1 = double.Parse(text_nota1.Text);
            n2 = double.Parse(text_nota2.Text);
            n3 = double.Parse(text_nota3.Text);

            p1 = n1 * 2;
            p2 = n2 * 3;
            p3 = n3 * 5;
            med = (p1 + p2 + p3) / 10;

            text_result.Text = med.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }
    }
}
