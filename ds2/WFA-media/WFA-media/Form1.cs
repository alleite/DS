﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_media
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

        private void btnResul_Click(object sender, EventArgs e)
        {
            media_calc op = new media_calc();
            double n1 = double.Parse(txtN1.Text);
            double n2 = double.Parse(txtN2.Text);
            double n3 = double.Parse(txtN3.Text);
            double n4 = double.Parse(txtN4.Text);
            txtResul.Text = "" + op.media_notas(n1, n2, n3, n4);
        }
    }
}
