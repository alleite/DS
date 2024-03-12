namespace WindowsFormsExercise2
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
            this.text_total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBranco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNulos = new System.Windows.Forms.TextBox();
            this.textValidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.text_result_branco = new System.Windows.Forms.TextBox();
            this.text_result_nul = new System.Windows.Forms.TextBox();
            this.text_result_val = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a quantidade total de eleitores:";
            // 
            // text_total
            // 
            this.text_total.Location = new System.Drawing.Point(12, 35);
            this.text_total.Name = "text_total";
            this.text_total.Size = new System.Drawing.Size(100, 20);
            this.text_total.TabIndex = 1;
            this.text_total.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite a quantidade total de votos em branco:";
            // 
            // textBranco
            // 
            this.textBranco.Location = new System.Drawing.Point(12, 74);
            this.textBranco.Name = "textBranco";
            this.textBranco.Size = new System.Drawing.Size(100, 20);
            this.textBranco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite a quantidade total de votos nulos:";
            // 
            // textNulos
            // 
            this.textNulos.Location = new System.Drawing.Point(12, 113);
            this.textNulos.Name = "textNulos";
            this.textNulos.Size = new System.Drawing.Size(100, 20);
            this.textNulos.TabIndex = 5;
            // 
            // textValidos
            // 
            this.textValidos.Location = new System.Drawing.Point(12, 152);
            this.textValidos.Name = "textValidos";
            this.textValidos.Size = new System.Drawing.Size(100, 20);
            this.textValidos.TabIndex = 6;
            this.textValidos.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digite a quantidade total de votos validos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "Converter pra porcentagem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_result_branco
            // 
            this.text_result_branco.Location = new System.Drawing.Point(12, 227);
            this.text_result_branco.Name = "text_result_branco";
            this.text_result_branco.ReadOnly = true;
            this.text_result_branco.Size = new System.Drawing.Size(100, 20);
            this.text_result_branco.TabIndex = 9;
            this.text_result_branco.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // text_result_nul
            // 
            this.text_result_nul.Location = new System.Drawing.Point(12, 266);
            this.text_result_nul.Name = "text_result_nul";
            this.text_result_nul.ReadOnly = true;
            this.text_result_nul.Size = new System.Drawing.Size(100, 20);
            this.text_result_nul.TabIndex = 10;
            this.text_result_nul.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // text_result_val
            // 
            this.text_result_val.Location = new System.Drawing.Point(12, 305);
            this.text_result_val.Name = "text_result_val";
            this.text_result_val.ReadOnly = true;
            this.text_result_val.Size = new System.Drawing.Size(100, 20);
            this.text_result_val.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Porcentagem de votos em branco:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Porcentagem de votos nulos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Porcentagem de votos validos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(399, 343);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_result_val);
            this.Controls.Add(this.text_result_nul);
            this.Controls.Add(this.text_result_branco);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textValidos);
            this.Controls.Add(this.textNulos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBranco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_total);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBranco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNulos;
        private System.Windows.Forms.TextBox textValidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_result_branco;
        private System.Windows.Forms.TextBox text_result_nul;
        private System.Windows.Forms.TextBox text_result_val;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

