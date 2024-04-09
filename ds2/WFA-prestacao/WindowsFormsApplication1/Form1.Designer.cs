namespace WindowsFormsApplication1
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
            this.txt_vprest = new System.Windows.Forms.TextBox();
            this.txt_taxa = new System.Windows.Forms.TextBox();
            this.txt_temp = new System.Windows.Forms.TextBox();
            this.txt_prest = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor da prestação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taxa de juros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dias em atraso:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prestação em atraso:";
            // 
            // txt_vprest
            // 
            this.txt_vprest.Location = new System.Drawing.Point(85, 27);
            this.txt_vprest.Name = "txt_vprest";
            this.txt_vprest.Size = new System.Drawing.Size(100, 20);
            this.txt_vprest.TabIndex = 4;
            // 
            // txt_taxa
            // 
            this.txt_taxa.Location = new System.Drawing.Point(88, 78);
            this.txt_taxa.Name = "txt_taxa";
            this.txt_taxa.Size = new System.Drawing.Size(100, 20);
            this.txt_taxa.TabIndex = 5;
            // 
            // txt_temp
            // 
            this.txt_temp.Location = new System.Drawing.Point(88, 130);
            this.txt_temp.Name = "txt_temp";
            this.txt_temp.Size = new System.Drawing.Size(100, 20);
            this.txt_temp.TabIndex = 6;
            // 
            // txt_prest
            // 
            this.txt_prest.Location = new System.Drawing.Point(88, 177);
            this.txt_prest.Name = "txt_prest";
            this.txt_prest.Size = new System.Drawing.Size(100, 20);
            this.txt_prest.TabIndex = 7;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(98, 215);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 8;
            this.btn_calc.Text = "calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txt_prest);
            this.Controls.Add(this.txt_temp);
            this.Controls.Add(this.txt_taxa);
            this.Controls.Add(this.txt_vprest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_vprest;
        private System.Windows.Forms.TextBox txt_taxa;
        private System.Windows.Forms.TextBox txt_temp;
        private System.Windows.Forms.TextBox txt_prest;
        private System.Windows.Forms.Button btn_calc;
    }
}

