namespace WFA_exemplo_polimorfismo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_dataVenc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Rb_comissionado = new System.Windows.Forms.RadioButton();
            this.Rb_horista = new System.Windows.Forms.RadioButton();
            this.Rb_assalariado = new System.Windows.Forms.RadioButton();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_nomeFunc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.txtSobrenome);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_sobrenome);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empregado";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(81, 78);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(142, 20);
            this.txt_cpf.TabIndex = 5;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(81, 51);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(142, 20);
            this.txtSobrenome.TabIndex = 4;
            this.txtSobrenome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(81, 27);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(142, 20);
            this.txt_nome.TabIndex = 3;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(6, 54);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(64, 13);
            this.lbl_sobrenome.TabIndex = 1;
            this.lbl_sobrenome.Text = "Sobrenome:";
            this.lbl_sobrenome.Click += new System.EventHandler(this.lbl_sobrenome_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(8, 30);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_dataVenc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(267, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vencimentos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbl_dataVenc
            // 
            this.lbl_dataVenc.AutoSize = true;
            this.lbl_dataVenc.Location = new System.Drawing.Point(120, 27);
            this.lbl_dataVenc.Name = "lbl_dataVenc";
            this.lbl_dataVenc.Size = new System.Drawing.Size(30, 13);
            this.lbl_dataVenc.TabIndex = 1;
            this.lbl_dataVenc.Text = "Data";
            this.lbl_dataVenc.Click += new System.EventHandler(this.lbl_dataVenc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data do Vencimento:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Rb_comissionado);
            this.groupBox3.Controls.Add(this.Rb_horista);
            this.groupBox3.Controls.Add(this.Rb_assalariado);
            this.groupBox3.Location = new System.Drawing.Point(12, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo empregado";
            // 
            // Rb_comissionado
            // 
            this.Rb_comissionado.AutoSize = true;
            this.Rb_comissionado.Location = new System.Drawing.Point(9, 69);
            this.Rb_comissionado.Name = "Rb_comissionado";
            this.Rb_comissionado.Size = new System.Drawing.Size(90, 17);
            this.Rb_comissionado.TabIndex = 2;
            this.Rb_comissionado.TabStop = true;
            this.Rb_comissionado.Text = "Comissionado";
            this.Rb_comissionado.UseVisualStyleBackColor = true;
            // 
            // Rb_horista
            // 
            this.Rb_horista.AutoSize = true;
            this.Rb_horista.Location = new System.Drawing.Point(9, 46);
            this.Rb_horista.Name = "Rb_horista";
            this.Rb_horista.Size = new System.Drawing.Size(58, 17);
            this.Rb_horista.TabIndex = 1;
            this.Rb_horista.TabStop = true;
            this.Rb_horista.Text = "Horista";
            this.Rb_horista.UseVisualStyleBackColor = true;
            // 
            // Rb_assalariado
            // 
            this.Rb_assalariado.AutoSize = true;
            this.Rb_assalariado.Location = new System.Drawing.Point(9, 23);
            this.Rb_assalariado.Name = "Rb_assalariado";
            this.Rb_assalariado.Size = new System.Drawing.Size(79, 17);
            this.Rb_assalariado.TabIndex = 0;
            this.Rb_assalariado.TabStop = true;
            this.Rb_assalariado.Text = "Assalariado";
            this.Rb_assalariado.UseVisualStyleBackColor = true;
            // 
            // btn_verificar
            // 
            this.btn_verificar.Location = new System.Drawing.Point(407, 324);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(89, 32);
            this.btn_verificar.TabIndex = 3;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_cpf);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lblSobrenome);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lbl_nomeFunc);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(267, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 139);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados do empregado ";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(120, 97);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(22, 13);
            this.lbl_cpf.TabIndex = 7;
            this.lbl_cpf.Text = "cpf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cpf:";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(120, 59);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 5;
            this.lblSobrenome.Text = "Sobrenome";
            this.lblSobrenome.Click += new System.EventHandler(this.lblSobrenome_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sobrenome:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_nomeFunc
            // 
            this.lbl_nomeFunc.AutoSize = true;
            this.lbl_nomeFunc.Location = new System.Drawing.Point(120, 27);
            this.lbl_nomeFunc.Name = "lbl_nomeFunc";
            this.lbl_nomeFunc.Size = new System.Drawing.Size(33, 13);
            this.lbl_nomeFunc.TabIndex = 3;
            this.lbl_nomeFunc.Text = "nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(525, 368);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_dataVenc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Rb_comissionado;
        private System.Windows.Forms.RadioButton Rb_horista;
        private System.Windows.Forms.RadioButton Rb_assalariado;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_nomeFunc;
    }
}

