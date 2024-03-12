namespace primeiro_exemplo_forms
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
            this.btn_click1 = new System.Windows.Forms.Button();
            this.btn_botao2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_click1
            // 
            this.btn_click1.BackColor = System.Drawing.Color.Salmon;
            this.btn_click1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_click1.Location = new System.Drawing.Point(225, 172);
            this.btn_click1.Name = "btn_click1";
            this.btn_click1.Size = new System.Drawing.Size(103, 42);
            this.btn_click1.TabIndex = 0;
            this.btn_click1.Text = "Click";
            this.btn_click1.UseVisualStyleBackColor = false;
            this.btn_click1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_botao2
            // 
            this.btn_botao2.BackColor = System.Drawing.Color.Violet;
            this.btn_botao2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_botao2.Location = new System.Drawing.Point(225, 220);
            this.btn_botao2.Name = "btn_botao2";
            this.btn_botao2.Size = new System.Drawing.Size(103, 46);
            this.btn_botao2.TabIndex = 1;
            this.btn_botao2.Text = "botão 2";
            this.btn_botao2.UseVisualStyleBackColor = false;
            this.btn_botao2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(557, 542);
            this.Controls.Add(this.btn_botao2);
            this.Controls.Add(this.btn_click1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_click1;
        private System.Windows.Forms.Button btn_botao2;
    }
}

