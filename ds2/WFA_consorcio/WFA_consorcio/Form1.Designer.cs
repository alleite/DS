namespace WFA_consorcio
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bnt_calc = new System.Windows.Forms.Button();
            this.txt_prest = new System.Windows.Forms.TextBox();
            this.txt_prestpagos = new System.Windows.Forms.TextBox();
            this.txt_vatual = new System.Windows.Forms.TextBox();
            this.txt_vtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_devedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de prestações:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidades de prestações pagas:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor total pago:";
            // 
            // bnt_calc
            // 
            this.bnt_calc.Location = new System.Drawing.Point(266, 230);
            this.bnt_calc.Name = "bnt_calc";
            this.bnt_calc.Size = new System.Drawing.Size(84, 23);
            this.bnt_calc.TabIndex = 4;
            this.bnt_calc.Text = "calcular";
            this.bnt_calc.UseVisualStyleBackColor = true;
            this.bnt_calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_prest
            // 
            this.txt_prest.Location = new System.Drawing.Point(97, 28);
            this.txt_prest.Name = "txt_prest";
            this.txt_prest.Size = new System.Drawing.Size(156, 20);
            this.txt_prest.TabIndex = 5;
            // 
            // txt_prestpagos
            // 
            this.txt_prestpagos.Location = new System.Drawing.Point(97, 69);
            this.txt_prestpagos.Name = "txt_prestpagos";
            this.txt_prestpagos.Size = new System.Drawing.Size(156, 20);
            this.txt_prestpagos.TabIndex = 6;
            // 
            // txt_vatual
            // 
            this.txt_vatual.Location = new System.Drawing.Point(97, 114);
            this.txt_vatual.Name = "txt_vatual";
            this.txt_vatual.Size = new System.Drawing.Size(156, 20);
            this.txt_vatual.TabIndex = 7;
            // 
            // txt_vtotal
            // 
            this.txt_vtotal.Location = new System.Drawing.Point(12, 182);
            this.txt_vtotal.Name = "txt_vtotal";
            this.txt_vtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_vtotal.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor de cada prestação:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Saldo devedor:";
            // 
            // txt_devedor
            // 
            this.txt_devedor.Location = new System.Drawing.Point(12, 230);
            this.txt_devedor.Name = "txt_devedor";
            this.txt_devedor.Size = new System.Drawing.Size(100, 20);
            this.txt_devedor.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(362, 262);
            this.Controls.Add(this.txt_devedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_vtotal);
            this.Controls.Add(this.txt_vatual);
            this.Controls.Add(this.txt_prestpagos);
            this.Controls.Add(this.txt_prest);
            this.Controls.Add(this.bnt_calc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bnt_calc;
        private System.Windows.Forms.TextBox txt_prest;
        private System.Windows.Forms.TextBox txt_prestpagos;
        private System.Windows.Forms.TextBox txt_vatual;
        private System.Windows.Forms.TextBox txt_vtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_devedor;
    }
}

