namespace WFA_uml
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
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_somar = new System.Windows.Forms.Button();
            this.bnt_sub = new System.Windows.Forms.Button();
            this.bnt_div = new System.Windows.Forms.Button();
            this.bnt_mult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o número 1:";
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(12, 25);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 20);
            this.txt_num1.TabIndex = 1;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(12, 70);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 20);
            this.txt_num2.TabIndex = 2;
            this.txt_num2.TextChanged += new System.EventHandler(this.txt_num2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o número 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado:";
            // 
            // txt_result
            // 
            this.txt_result.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_result.Location = new System.Drawing.Point(12, 118);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 5;
            // 
            // btn_somar
            // 
            this.btn_somar.Location = new System.Drawing.Point(12, 197);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(75, 23);
            this.btn_somar.TabIndex = 6;
            this.btn_somar.Text = "Somar";
            this.btn_somar.UseVisualStyleBackColor = true;
            this.btn_somar.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // bnt_sub
            // 
            this.bnt_sub.Location = new System.Drawing.Point(93, 197);
            this.bnt_sub.Name = "bnt_sub";
            this.bnt_sub.Size = new System.Drawing.Size(75, 23);
            this.bnt_sub.TabIndex = 7;
            this.bnt_sub.Text = "Sub";
            this.bnt_sub.UseVisualStyleBackColor = true;
            this.bnt_sub.Click += new System.EventHandler(this.bnt_sub_Click);
            // 
            // bnt_div
            // 
            this.bnt_div.Location = new System.Drawing.Point(174, 197);
            this.bnt_div.Name = "bnt_div";
            this.bnt_div.Size = new System.Drawing.Size(75, 23);
            this.bnt_div.TabIndex = 8;
            this.bnt_div.Text = "Divisão";
            this.bnt_div.UseVisualStyleBackColor = true;
            this.bnt_div.Click += new System.EventHandler(this.bnt_div_Click);
            // 
            // bnt_mult
            // 
            this.bnt_mult.Location = new System.Drawing.Point(255, 197);
            this.bnt_mult.Name = "bnt_mult";
            this.bnt_mult.Size = new System.Drawing.Size(75, 23);
            this.bnt_mult.TabIndex = 9;
            this.bnt_mult.Text = "Mult";
            this.bnt_mult.UseVisualStyleBackColor = true;
            this.bnt_mult.Click += new System.EventHandler(this.bnt_mult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.bnt_mult);
            this.Controls.Add(this.bnt_div);
            this.Controls.Add(this.bnt_sub);
            this.Controls.Add(this.btn_somar);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_somar;
        private System.Windows.Forms.Button bnt_sub;
        private System.Windows.Forms.Button bnt_div;
        private System.Windows.Forms.Button bnt_mult;
    }
}

