namespace Imc
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
            this.lbl_imc = new System.Windows.Forms.Label();
            this.txt_alt = new System.Windows.Forms.TextBox();
            this.txt_pes = new System.Windows.Forms.TextBox();
            this.btn_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite sua altura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o seu peso:";
            // 
            // lbl_imc
            // 
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Location = new System.Drawing.Point(12, 163);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(78, 13);
            this.lbl_imc.TabIndex = 2;
            this.lbl_imc.Text = "Resultado Imc:";
            // 
            // txt_alt
            // 
            this.txt_alt.Location = new System.Drawing.Point(12, 30);
            this.txt_alt.Name = "txt_alt";
            this.txt_alt.Size = new System.Drawing.Size(100, 20);
            this.txt_alt.TabIndex = 3;
            this.txt_alt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_pes
            // 
            this.txt_pes.Location = new System.Drawing.Point(12, 93);
            this.txt_pes.Name = "txt_pes";
            this.txt_pes.Size = new System.Drawing.Size(100, 20);
            this.txt_pes.TabIndex = 4;
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(187, 214);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(75, 23);
            this.btn_result.TabIndex = 5;
            this.btn_result.Text = "Converter";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 249);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.txt_pes);
            this.Controls.Add(this.txt_alt);
            this.Controls.Add(this.lbl_imc);
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
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.TextBox txt_alt;
        private System.Windows.Forms.TextBox txt_pes;
        private System.Windows.Forms.Button btn_result;
    }
}

