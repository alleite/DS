namespace WFA_exemplo_encapsulamento
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
            this.btn_armazenar_set = new System.Windows.Forms.Button();
            this.bnt_mostrar_get = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_mostrar_nome = new System.Windows.Forms.Label();
            this.lbl_mostrar_cpf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_armazenar_set
            // 
            this.btn_armazenar_set.Location = new System.Drawing.Point(257, 30);
            this.btn_armazenar_set.Name = "btn_armazenar_set";
            this.btn_armazenar_set.Size = new System.Drawing.Size(112, 49);
            this.btn_armazenar_set.TabIndex = 0;
            this.btn_armazenar_set.Text = "Armazenar em Set";
            this.btn_armazenar_set.UseVisualStyleBackColor = true;
            this.btn_armazenar_set.Click += new System.EventHandler(this.button1_Click);
            // 
            // bnt_mostrar_get
            // 
            this.bnt_mostrar_get.Location = new System.Drawing.Point(257, 115);
            this.bnt_mostrar_get.Name = "bnt_mostrar_get";
            this.bnt_mostrar_get.Size = new System.Drawing.Size(112, 49);
            this.bnt_mostrar_get.TabIndex = 1;
            this.bnt_mostrar_get.Text = "Mostrar em Get";
            this.bnt_mostrar_get.UseVisualStyleBackColor = true;
            this.bnt_mostrar_get.Click += new System.EventHandler(this.bnt_mostrar_get_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(15, 30);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(219, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(15, 82);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(219, 20);
            this.txt_cpf.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite o CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome do Aluno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF do Aluno:";
            // 
            // lbl_mostrar_nome
            // 
            this.lbl_mostrar_nome.AutoSize = true;
            this.lbl_mostrar_nome.Location = new System.Drawing.Point(101, 133);
            this.lbl_mostrar_nome.Name = "lbl_mostrar_nome";
            this.lbl_mostrar_nome.Size = new System.Drawing.Size(71, 13);
            this.lbl_mostrar_nome.TabIndex = 8;
            this.lbl_mostrar_nome.Text = "Mostrar nome";
            // 
            // lbl_mostrar_cpf
            // 
            this.lbl_mostrar_cpf.AutoSize = true;
            this.lbl_mostrar_cpf.Location = new System.Drawing.Point(101, 164);
            this.lbl_mostrar_cpf.Name = "lbl_mostrar_cpf";
            this.lbl_mostrar_cpf.Size = new System.Drawing.Size(65, 13);
            this.lbl_mostrar_cpf.TabIndex = 9;
            this.lbl_mostrar_cpf.Text = "Mostrar CPF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(410, 198);
            this.Controls.Add(this.lbl_mostrar_cpf);
            this.Controls.Add(this.lbl_mostrar_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnt_mostrar_get);
            this.Controls.Add(this.btn_armazenar_set);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_armazenar_set;
        private System.Windows.Forms.Button bnt_mostrar_get;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_mostrar_nome;
        private System.Windows.Forms.Label lbl_mostrar_cpf;
    }
}

