namespace wfa_supermercado
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_quant_max = new System.Windows.Forms.TextBox();
            this.lbl_quant_max = new System.Windows.Forms.Label();
            this.lbl_quant_estq = new System.Windows.Forms.Label();
            this.txt_quant_estq = new System.Windows.Forms.TextBox();
            this.btn_botao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(92, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome do produto:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(12, 25);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(140, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_quant_max
            // 
            this.txt_quant_max.Location = new System.Drawing.Point(12, 75);
            this.txt_quant_max.Name = "txt_quant_max";
            this.txt_quant_max.Size = new System.Drawing.Size(140, 20);
            this.txt_quant_max.TabIndex = 2;
            // 
            // lbl_quant_max
            // 
            this.lbl_quant_max.AutoSize = true;
            this.lbl_quant_max.Location = new System.Drawing.Point(12, 59);
            this.lbl_quant_max.Name = "lbl_quant_max";
            this.lbl_quant_max.Size = new System.Drawing.Size(140, 13);
            this.lbl_quant_max.TabIndex = 3;
            this.lbl_quant_max.Text = "Digite a quantidade máxima:";
            // 
            // lbl_quant_estq
            // 
            this.lbl_quant_estq.AutoSize = true;
            this.lbl_quant_estq.Location = new System.Drawing.Point(12, 111);
            this.lbl_quant_estq.Name = "lbl_quant_estq";
            this.lbl_quant_estq.Size = new System.Drawing.Size(160, 13);
            this.lbl_quant_estq.TabIndex = 4;
            this.lbl_quant_estq.Text = "Digite a quantidade em estoque:";
            // 
            // txt_quant_estq
            // 
            this.txt_quant_estq.Location = new System.Drawing.Point(12, 127);
            this.txt_quant_estq.Name = "txt_quant_estq";
            this.txt_quant_estq.Size = new System.Drawing.Size(140, 20);
            this.txt_quant_estq.TabIndex = 5;
            // 
            // btn_botao
            // 
            this.btn_botao.Location = new System.Drawing.Point(192, 215);
            this.btn_botao.Name = "btn_botao";
            this.btn_botao.Size = new System.Drawing.Size(84, 53);
            this.btn_botao.TabIndex = 6;
            this.btn_botao.Text = "Calcular";
            this.btn_botao.UseVisualStyleBackColor = true;
            this.btn_botao.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade a comprar";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(15, 179);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(137, 20);
            this.txt_result.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(288, 280);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_botao);
            this.Controls.Add(this.txt_quant_estq);
            this.Controls.Add(this.lbl_quant_estq);
            this.Controls.Add(this.lbl_quant_max);
            this.Controls.Add(this.txt_quant_max);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_quant_max;
        private System.Windows.Forms.Label lbl_quant_max;
        private System.Windows.Forms.Label lbl_quant_estq;
        private System.Windows.Forms.TextBox txt_quant_estq;
        private System.Windows.Forms.Button btn_botao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_result;
    }
}

