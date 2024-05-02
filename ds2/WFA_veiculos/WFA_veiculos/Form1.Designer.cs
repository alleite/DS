namespace WFA_veiculos
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnt_verificar = new System.Windows.Forms.Button();
            this.Rb_fina = new System.Windows.Forms.RadioButton();
            this.Rb_medio = new System.Windows.Forms.RadioButton();
            this.Rb_grossa = new System.Windows.Forms.RadioButton();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numPortas = new System.Windows.Forms.TextBox();
            this.txt_numRodas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_cor = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.lbl_frabric = new System.Windows.Forms.Label();
            this.lbl_rodas = new System.Windows.Forms.Label();
            this.lbl_expessura = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_numRodas);
            this.groupBox1.Controls.Add(this.txt_numPortas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_ano);
            this.groupBox1.Controls.Add(this.txt_modelo);
            this.groupBox1.Controls.Add(this.txt_cor);
            this.groupBox1.Controls.Add(this.Rb_grossa);
            this.groupBox1.Controls.Add(this.Rb_medio);
            this.groupBox1.Controls.Add(this.Rb_fina);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Carro";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_expessura);
            this.groupBox2.Controls.Add(this.lbl_rodas);
            this.groupBox2.Controls.Add(this.lbl_frabric);
            this.groupBox2.Controls.Add(this.lbl_ano);
            this.groupBox2.Controls.Add(this.lbl_modelo);
            this.groupBox2.Controls.Add(this.lbl_cor);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(280, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // bnt_verificar
            // 
            this.bnt_verificar.Location = new System.Drawing.Point(361, 310);
            this.bnt_verificar.Name = "bnt_verificar";
            this.bnt_verificar.Size = new System.Drawing.Size(113, 38);
            this.bnt_verificar.TabIndex = 2;
            this.bnt_verificar.Text = "Verificar";
            this.bnt_verificar.UseVisualStyleBackColor = true;
            this.bnt_verificar.Click += new System.EventHandler(this.bnt_verificar_Click);
            // 
            // Rb_fina
            // 
            this.Rb_fina.AutoSize = true;
            this.Rb_fina.Location = new System.Drawing.Point(16, 236);
            this.Rb_fina.Name = "Rb_fina";
            this.Rb_fina.Size = new System.Drawing.Size(45, 17);
            this.Rb_fina.TabIndex = 0;
            this.Rb_fina.TabStop = true;
            this.Rb_fina.Text = "Fina";
            this.Rb_fina.UseVisualStyleBackColor = true;
            // 
            // Rb_medio
            // 
            this.Rb_medio.AutoSize = true;
            this.Rb_medio.Location = new System.Drawing.Point(16, 259);
            this.Rb_medio.Name = "Rb_medio";
            this.Rb_medio.Size = new System.Drawing.Size(54, 17);
            this.Rb_medio.TabIndex = 1;
            this.Rb_medio.TabStop = true;
            this.Rb_medio.Text = "Média";
            this.Rb_medio.UseVisualStyleBackColor = true;
            // 
            // Rb_grossa
            // 
            this.Rb_grossa.AutoSize = true;
            this.Rb_grossa.Location = new System.Drawing.Point(16, 282);
            this.Rb_grossa.Name = "Rb_grossa";
            this.Rb_grossa.Size = new System.Drawing.Size(58, 17);
            this.Rb_grossa.TabIndex = 2;
            this.Rb_grossa.TabStop = true;
            this.Rb_grossa.Text = "Grossa";
            this.Rb_grossa.UseVisualStyleBackColor = true;
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(106, 26);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(150, 20);
            this.txt_cor.TabIndex = 3;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(106, 63);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(150, 20);
            this.txt_modelo.TabIndex = 4;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(106, 100);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(150, 20);
            this.txt_ano.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cor do carro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo do carro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ano de fabricação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Número de portas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Número de rodas:";
            // 
            // txt_numPortas
            // 
            this.txt_numPortas.Location = new System.Drawing.Point(106, 140);
            this.txt_numPortas.Name = "txt_numPortas";
            this.txt_numPortas.Size = new System.Drawing.Size(150, 20);
            this.txt_numPortas.TabIndex = 11;
            // 
            // txt_numRodas
            // 
            this.txt_numRodas.Location = new System.Drawing.Point(106, 177);
            this.txt_numRodas.Name = "txt_numRodas";
            this.txt_numRodas.Size = new System.Drawing.Size(150, 20);
            this.txt_numRodas.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Expessura da roda:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Número de rodas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Número de portas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ano de fabricação:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Modelo do carro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Cor do carro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 206);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Expessura da roda:";
            // 
            // lbl_cor
            // 
            this.lbl_cor.AutoSize = true;
            this.lbl_cor.Location = new System.Drawing.Point(110, 29);
            this.lbl_cor.Name = "lbl_cor";
            this.lbl_cor.Size = new System.Drawing.Size(22, 13);
            this.lbl_cor.TabIndex = 17;
            this.lbl_cor.Text = "cor";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(110, 66);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(41, 13);
            this.lbl_modelo.TabIndex = 18;
            this.lbl_modelo.Text = "modelo";
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(109, 103);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(26, 13);
            this.lbl_ano.TabIndex = 19;
            this.lbl_ano.Text = "Ano";
            // 
            // lbl_frabric
            // 
            this.lbl_frabric.AutoSize = true;
            this.lbl_frabric.Location = new System.Drawing.Point(110, 140);
            this.lbl_frabric.Name = "lbl_frabric";
            this.lbl_frabric.Size = new System.Drawing.Size(36, 13);
            this.lbl_frabric.TabIndex = 20;
            this.lbl_frabric.Text = "portas";
            // 
            // lbl_rodas
            // 
            this.lbl_rodas.AutoSize = true;
            this.lbl_rodas.Location = new System.Drawing.Point(110, 177);
            this.lbl_rodas.Name = "lbl_rodas";
            this.lbl_rodas.Size = new System.Drawing.Size(33, 13);
            this.lbl_rodas.TabIndex = 21;
            this.lbl_rodas.Text = "rodas";
            // 
            // lbl_expessura
            // 
            this.lbl_expessura.AutoSize = true;
            this.lbl_expessura.Location = new System.Drawing.Point(110, 206);
            this.lbl_expessura.Name = "lbl_expessura";
            this.lbl_expessura.Size = new System.Drawing.Size(55, 13);
            this.lbl_expessura.TabIndex = 22;
            this.lbl_expessura.Text = "expessura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(522, 380);
            this.Controls.Add(this.bnt_verificar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rb_grossa;
        private System.Windows.Forms.RadioButton Rb_medio;
        private System.Windows.Forms.RadioButton Rb_fina;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnt_verificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_numRodas;
        private System.Windows.Forms.TextBox txt_numPortas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_expessura;
        private System.Windows.Forms.Label lbl_rodas;
        private System.Windows.Forms.Label lbl_frabric;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_cor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

