namespace WFA_exemplo_heranca
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
            this.lbl = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.txt_cartao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bnt_get_set = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_cartao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 31);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(38, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(53, 28);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(53, 67);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(100, 20);
            this.txt_rg.TabIndex = 2;
            // 
            // txt_cartao
            // 
            this.txt_cartao.Location = new System.Drawing.Point(53, 107);
            this.txt_cartao.Name = "txt_cartao";
            this.txt_cartao.Size = new System.Drawing.Size(100, 20);
            this.txt_cartao.TabIndex = 3;
            this.txt_cartao.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RG:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cartão:";
            // 
            // bnt_get_set
            // 
            this.bnt_get_set.Location = new System.Drawing.Point(231, 31);
            this.bnt_get_set.Name = "bnt_get_set";
            this.bnt_get_set.Size = new System.Drawing.Size(111, 56);
            this.bnt_get_set.TabIndex = 6;
            this.bnt_get_set.Text = "Armazenar e demonstrar";
            this.bnt_get_set.UseVisualStyleBackColor = true;
            this.bnt_get_set.Click += new System.EventHandler(this.bnt_get_set_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exibir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(86, 174);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "RG:";
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Location = new System.Drawing.Point(86, 206);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(35, 13);
            this.lbl_rg.TabIndex = 11;
            this.lbl_rg.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cartão:";
            // 
            // lbl_cartao
            // 
            this.lbl_cartao.AutoSize = true;
            this.lbl_cartao.Location = new System.Drawing.Point(86, 237);
            this.lbl_cartao.Name = "lbl_cartao";
            this.lbl_cartao.Size = new System.Drawing.Size(41, 13);
            this.lbl_cartao.TabIndex = 13;
            this.lbl_cartao.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 298);
            this.Controls.Add(this.lbl_cartao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_rg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bnt_get_set);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cartao);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.TextBox txt_cartao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnt_get_set;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_cartao;
    }
}

