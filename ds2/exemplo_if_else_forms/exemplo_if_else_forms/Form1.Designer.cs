namespace exemplo_if_else_forms
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
            this.rbd_manha = new System.Windows.Forms.RadioButton();
            this.rbd_tarde = new System.Windows.Forms.RadioButton();
            this.rbd_noite = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnt_escolha = new System.Windows.Forms.Button();
            this.text_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_confere = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbd_manha
            // 
            this.rbd_manha.AutoSize = true;
            this.rbd_manha.Location = new System.Drawing.Point(6, 45);
            this.rbd_manha.Name = "rbd_manha";
            this.rbd_manha.Size = new System.Drawing.Size(58, 17);
            this.rbd_manha.TabIndex = 0;
            this.rbd_manha.Text = "Manhã";
            this.rbd_manha.UseVisualStyleBackColor = true;
            this.rbd_manha.CheckedChanged += new System.EventHandler(this.rbd_manha_CheckedChanged);
            // 
            // rbd_tarde
            // 
            this.rbd_tarde.AutoSize = true;
            this.rbd_tarde.Location = new System.Drawing.Point(6, 68);
            this.rbd_tarde.Name = "rbd_tarde";
            this.rbd_tarde.Size = new System.Drawing.Size(53, 17);
            this.rbd_tarde.TabIndex = 1;
            this.rbd_tarde.Text = "Tarde";
            this.rbd_tarde.UseVisualStyleBackColor = true;
            // 
            // rbd_noite
            // 
            this.rbd_noite.AutoSize = true;
            this.rbd_noite.Location = new System.Drawing.Point(6, 91);
            this.rbd_noite.Name = "rbd_noite";
            this.rbd_noite.Size = new System.Drawing.Size(50, 17);
            this.rbd_noite.TabIndex = 2;
            this.rbd_noite.Text = "Noite";
            this.rbd_noite.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnt_escolha);
            this.groupBox1.Controls.Add(this.rbd_tarde);
            this.groupBox1.Controls.Add(this.rbd_noite);
            this.groupBox1.Controls.Add(this.rbd_manha);
            this.groupBox1.Location = new System.Drawing.Point(56, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha um periodo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bnt_escolha
            // 
            this.bnt_escolha.Location = new System.Drawing.Point(151, 99);
            this.bnt_escolha.Name = "bnt_escolha";
            this.bnt_escolha.Size = new System.Drawing.Size(75, 23);
            this.bnt_escolha.TabIndex = 3;
            this.bnt_escolha.Text = "Escolher";
            this.bnt_escolha.UseVisualStyleBackColor = true;
            this.bnt_escolha.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_num
            // 
            this.text_num.Location = new System.Drawing.Point(20, 241);
            this.text_num.Name = "text_num";
            this.text_num.Size = new System.Drawing.Size(100, 20);
            this.text_num.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite um número";
            // 
            // btn_confere
            // 
            this.btn_confere.Location = new System.Drawing.Point(20, 280);
            this.btn_confere.Name = "btn_confere";
            this.btn_confere.Size = new System.Drawing.Size(75, 23);
            this.btn_confere.TabIndex = 6;
            this.btn_confere.Text = "Conferir";
            this.btn_confere.UseVisualStyleBackColor = true;
            this.btn_confere.Click += new System.EventHandler(this.btn_confere_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(145, 248);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(55, 13);
            this.lbl_result.TabIndex = 7;
            this.lbl_result.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(350, 609);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_confere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_num);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbd_manha;
        private System.Windows.Forms.RadioButton rbd_tarde;
        private System.Windows.Forms.RadioButton rbd_noite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bnt_escolha;
        private System.Windows.Forms.TextBox text_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_confere;
        private System.Windows.Forms.Label lbl_result;
    }
}

