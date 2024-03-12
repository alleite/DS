namespace WindowsFormsExercise3
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
            this.text_nota1 = new System.Windows.Forms.TextBox();
            this.text_nota2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_nota3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.text_result = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a primeira nota:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_nota1
            // 
            this.text_nota1.Location = new System.Drawing.Point(12, 25);
            this.text_nota1.Name = "text_nota1";
            this.text_nota1.Size = new System.Drawing.Size(100, 20);
            this.text_nota1.TabIndex = 1;
            // 
            // text_nota2
            // 
            this.text_nota2.Location = new System.Drawing.Point(12, 68);
            this.text_nota2.Name = "text_nota2";
            this.text_nota2.Size = new System.Drawing.Size(100, 20);
            this.text_nota2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite a segunda nota:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Digite a terceira nota:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // text_nota3
            // 
            this.text_nota3.Location = new System.Drawing.Point(12, 116);
            this.text_nota3.Name = "text_nota3";
            this.text_nota3.Size = new System.Drawing.Size(100, 20);
            this.text_nota3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Converter média";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_result
            // 
            this.text_result.Location = new System.Drawing.Point(12, 198);
            this.text_result.Name = "text_result";
            this.text_result.ReadOnly = true;
            this.text_result.Size = new System.Drawing.Size(100, 20);
            this.text_result.TabIndex = 7;
            this.text_result.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado da média:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(287, 297);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_nota3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_nota2);
            this.Controls.Add(this.text_nota1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_nota1;
        private System.Windows.Forms.TextBox text_nota2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_nota3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_result;
        private System.Windows.Forms.Label label4;
    }
}

