﻿namespace wfa_locadora
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
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.lbl_data_devolucao = new System.Windows.Forms.Label();
            this.lbl_dt_retirada = new System.Windows.Forms.Label();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.txt_data_devolucao = new System.Windows.Forms.TextBox();
            this.txt_data_retirada = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.txt_codg_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_codigo_filme = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_filme = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_filme = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.btn_limpar);
            this.groupBox1.Controls.Add(this.btn_alterar);
            this.groupBox1.Controls.Add(this.btn_consultar);
            this.groupBox1.Controls.Add(this.btn_salvar);
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
            this.groupBox1.Controls.Add(this.txt_codigo_filme);
            this.groupBox1.Controls.Add(this.txt_telefone);
            this.groupBox1.Controls.Add(this.txt_filme);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.lbl_filme);
            this.groupBox1.Controls.Add(this.lbl_telefone);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 552);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locadora";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Image = global::wfa_locadora.Properties.Resources.delete_document_outlined_interface_symbol_icon_icons_com_57867;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.Location = new System.Drawing.Point(621, 97);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(118, 67);
            this.btn_excluir.TabIndex = 29;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Image = global::wfa_locadora.Properties.Resources.clean_floor_icon_133599;
            this.btn_limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpar.Location = new System.Drawing.Point(621, 19);
            this.btn_limpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(118, 67);
            this.btn_limpar.TabIndex = 28;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Image = global::wfa_locadora.Properties.Resources._4124824_cog_web_options_web_preferences_web_setting_webpage_1138851;
            this.btn_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_alterar.Location = new System.Drawing.Point(498, 181);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(118, 65);
            this.btn_alterar.TabIndex = 27;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Image = global::wfa_locadora.Properties.Resources.search_magnifyng_glass_search_locate_icon_124190;
            this.btn_consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_consultar.Location = new System.Drawing.Point(498, 97);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(118, 67);
            this.btn_consultar.TabIndex = 26;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Image = global::wfa_locadora.Properties.Resources.savedisk_121993;
            this.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salvar.Location = new System.Drawing.Point(498, 19);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(118, 67);
            this.btn_salvar.TabIndex = 25;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
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
            // lbl_dt_retirada
            // 
            this.lbl_dt_retirada.AutoSize = true;
            this.lbl_dt_retirada.Location = new System.Drawing.Point(282, 151);
            this.lbl_dt_retirada.Name = "lbl_dt_retirada";
            this.lbl_dt_retirada.Size = new System.Drawing.Size(86, 13);
            this.lbl_dt_retirada.TabIndex = 23;
            this.lbl_dt_retirada.Text = "Data de retirada:";
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
            // txt_data_devolucao
            // 
            this.txt_data_devolucao.Location = new System.Drawing.Point(285, 223);
            this.txt_data_devolucao.Name = "txt_data_devolucao";
            this.txt_data_devolucao.Size = new System.Drawing.Size(186, 20);
            this.txt_data_devolucao.TabIndex = 21;
            // 
            // txt_data_retirada
            // 
            this.txt_data_retirada.Location = new System.Drawing.Point(285, 167);
            this.txt_data_retirada.Name = "txt_data_retirada";
            this.txt_data_retirada.Size = new System.Drawing.Size(186, 20);
            this.txt_data_retirada.TabIndex = 20;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(42, 223);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(186, 20);
            this.txt_cliente.TabIndex = 19;
            // 
            // txt_codg_cliente
            // 
            this.txt_codg_cliente.Location = new System.Drawing.Point(42, 167);
            this.txt_codg_cliente.Name = "txt_codg_cliente";
            this.txt_codg_cliente.Size = new System.Drawing.Size(186, 20);
            this.txt_codg_cliente.TabIndex = 18;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(722, 243);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // txt_codigo_filme
            // 
            this.txt_codigo_filme.Location = new System.Drawing.Point(285, 107);
            this.txt_codigo_filme.Name = "txt_codigo_filme";
            this.txt_codigo_filme.Size = new System.Drawing.Size(186, 20);
            this.txt_codigo_filme.TabIndex = 14;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 576);
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
        private System.Windows.Forms.TextBox txt_codigo_filme;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_filme;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_filme;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_excluir;
    }
}

