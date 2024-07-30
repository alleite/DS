namespace wfa_locadora
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_filme = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_filme = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codg_cliente = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.txt_data_retirada = new System.Windows.Forms.TextBox();
            this.txt_data_devolucao = new System.Windows.Forms.TextBox();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.lbl_dt_retirada = new System.Windows.Forms.Label();
            this.lbl_data_devolucao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.lbl_data_devolucao);
            this.groupBox1.Controls.Add(this.lbl_dt_retirada);
            this.groupBox1.Controls.Add(this.lbl_rg);
            this.groupBox1.Controls.Add(this.txt_data_devolucao);
            this.groupBox1.Controls.Add(this.txt_data_retirada);
            this.groupBox1.Controls.Add(this.txt_cliente);
            this.groupBox1.Controls.Add(this.txt_codg_cliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.txt_telefone);
            this.groupBox1.Controls.Add(this.txt_filme);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.lbl_filme);
            this.groupBox1.Controls.Add(this.lbl_telefone);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 552);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locadora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Código do filme:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(285, 107);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(186, 20);
            this.textBox4.TabIndex = 14;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(42, 107);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(186, 20);
            this.txt_telefone.TabIndex = 13;
            // 
            // txt_filme
            // 
            this.txt_filme.Location = new System.Drawing.Point(285, 45);
            this.txt_filme.Name = "txt_filme";
            this.txt_filme.Size = new System.Drawing.Size(186, 20);
            this.txt_filme.TabIndex = 12;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(42, 45);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(186, 20);
            this.txt_nome.TabIndex = 11;
            // 
            // lbl_filme
            // 
            this.lbl_filme.AutoSize = true;
            this.lbl_filme.Location = new System.Drawing.Point(282, 29);
            this.lbl_filme.Name = "lbl_filme";
            this.lbl_filme.Size = new System.Drawing.Size(77, 13);
            this.lbl_filme.TabIndex = 10;
            this.lbl_filme.Text = "Nome do filme:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(39, 91);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(103, 13);
            this.lbl_telefone.TabIndex = 9;
            this.lbl_telefone.Text = "Número de telefone:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(39, 29);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(84, 13);
            this.lbl_nome.TabIndex = 8;
            this.lbl_nome.Text = "Nome completo:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 243);
            this.dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código do cliente:";
            // 
            // txt_codg_cliente
            // 
            this.txt_codg_cliente.Location = new System.Drawing.Point(42, 167);
            this.txt_codg_cliente.Name = "txt_codg_cliente";
            this.txt_codg_cliente.Size = new System.Drawing.Size(186, 20);
            this.txt_codg_cliente.TabIndex = 18;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(42, 223);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(186, 20);
            this.txt_cliente.TabIndex = 19;
            // 
            // txt_data_retirada
            // 
            this.txt_data_retirada.Location = new System.Drawing.Point(285, 167);
            this.txt_data_retirada.Name = "txt_data_retirada";
            this.txt_data_retirada.Size = new System.Drawing.Size(186, 20);
            this.txt_data_retirada.TabIndex = 20;
            // 
            // txt_data_devolucao
            // 
            this.txt_data_devolucao.Location = new System.Drawing.Point(285, 223);
            this.txt_data_devolucao.Name = "txt_data_devolucao";
            this.txt_data_devolucao.Size = new System.Drawing.Size(186, 20);
            this.txt_data_devolucao.TabIndex = 21;
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Location = new System.Drawing.Point(39, 207);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(75, 13);
            this.lbl_rg.TabIndex = 22;
            this.lbl_rg.Text = "RG do cliente:";
            // 
            // lbl_dt_retirada
            // 
            this.lbl_dt_retirada.AutoSize = true;
            this.lbl_dt_retirada.Location = new System.Drawing.Point(282, 151);
            this.lbl_dt_retirada.Name = "lbl_dt_retirada";
            this.lbl_dt_retirada.Size = new System.Drawing.Size(86, 13);
            this.lbl_dt_retirada.TabIndex = 23;
            this.lbl_dt_retirada.Text = "Data de retirada:";
            // 
            // lbl_data_devolucao
            // 
            this.lbl_data_devolucao.AutoSize = true;
            this.lbl_data_devolucao.Location = new System.Drawing.Point(282, 207);
            this.lbl_data_devolucao.Name = "lbl_data_devolucao";
            this.lbl_data_devolucao.Size = new System.Drawing.Size(101, 13);
            this.lbl_data_devolucao.TabIndex = 24;
            this.lbl_data_devolucao.Text = "Data de devolução:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 576);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_data_devolucao;
        private System.Windows.Forms.Label lbl_dt_retirada;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.TextBox txt_data_devolucao;
        private System.Windows.Forms.TextBox txt_data_retirada;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.TextBox txt_codg_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_filme;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_filme;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_nome;
    }
}

