namespace exemplo_operacao_forms
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
            this.label3 = new System.Windows.Forms.Label();
            this.text_num1 = new System.Windows.Forms.TextBox();
            this.text_num2 = new System.Windows.Forms.TextBox();
            this.text_resultado = new System.Windows.Forms.TextBox();
            this.text_num3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bnt_sub = new System.Windows.Forms.Button();
            this.bnt_div = new System.Windows.Forms.Button();
            this.bnt_mult = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o 1° número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o 2° número";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // text_num1
            // 
            this.text_num1.Location = new System.Drawing.Point(154, 51);
            this.text_num1.Name = "text_num1";
            this.text_num1.Size = new System.Drawing.Size(129, 20);
            this.text_num1.TabIndex = 4;
            // 
            // text_num2
            // 
            this.text_num2.Location = new System.Drawing.Point(154, 91);
            this.text_num2.Name = "text_num2";
            this.text_num2.Size = new System.Drawing.Size(129, 20);
            this.text_num2.TabIndex = 5;
            // 
            // text_resultado
            // 
            this.text_resultado.Location = new System.Drawing.Point(154, 168);
            this.text_resultado.Name = "text_resultado";
            this.text_resultado.ReadOnly = true;
            this.text_resultado.Size = new System.Drawing.Size(129, 20);
            this.text_resultado.TabIndex = 6;
            // 
            // text_num3
            // 
            this.text_num3.Location = new System.Drawing.Point(154, 129);
            this.text_num3.Name = "text_num3";
            this.text_num3.Size = new System.Drawing.Size(129, 20);
            this.text_num3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digite o 3° número";
            // 
            // bnt_sub
            // 
            this.bnt_sub.Image = global::exemplo_operacao_forms.Properties.Resources._1904666_calculate_close_delete_hide_minimize_minus_remove_122516;
            this.bnt_sub.Location = new System.Drawing.Point(327, 238);
            this.bnt_sub.Name = "bnt_sub";
            this.bnt_sub.Size = new System.Drawing.Size(99, 48);
            this.bnt_sub.TabIndex = 11;
            this.bnt_sub.Text = "Subtração";
            this.bnt_sub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnt_sub.UseVisualStyleBackColor = true;
            this.bnt_sub.Click += new System.EventHandler(this.bnt_sub_Click);
            // 
            // bnt_div
            // 
            this.bnt_div.Image = global::exemplo_operacao_forms.Properties.Resources.divide_math_icon_214219;
            this.bnt_div.Location = new System.Drawing.Point(117, 238);
            this.bnt_div.Name = "bnt_div";
            this.bnt_div.Size = new System.Drawing.Size(99, 48);
            this.bnt_div.TabIndex = 10;
            this.bnt_div.Text = "divisão";
            this.bnt_div.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnt_div.UseVisualStyleBackColor = true;
            this.bnt_div.Click += new System.EventHandler(this.button2_Click);
            // 
            // bnt_mult
            // 
            this.bnt_mult.Image = global::exemplo_operacao_forms.Properties.Resources._1904654_cancel_close_cross_delete_reject_remove_stop_122504;
            this.bnt_mult.Location = new System.Drawing.Point(12, 238);
            this.bnt_mult.Name = "bnt_mult";
            this.bnt_mult.Size = new System.Drawing.Size(99, 48);
            this.bnt_mult.TabIndex = 9;
            this.bnt_mult.Text = "Multiplicar";
            this.bnt_mult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bnt_mult.UseVisualStyleBackColor = true;
            this.bnt_mult.Click += new System.EventHandler(this.bnt_mult_Click);
            // 
            // btn_soma
            // 
            this.btn_soma.Image = global::exemplo_operacao_forms.Properties.Resources._1904677_add_addition_calculate_charge_create_new_plus_122527;
            this.btn_soma.Location = new System.Drawing.Point(222, 238);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(99, 48);
            this.btn_soma.TabIndex = 0;
            this.btn_soma.Text = "Somar";
            this.btn_soma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(450, 308);
            this.Controls.Add(this.bnt_sub);
            this.Controls.Add(this.bnt_div);
            this.Controls.Add(this.bnt_mult);
            this.Controls.Add(this.text_num3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_resultado);
            this.Controls.Add(this.text_num2);
            this.Controls.Add(this.text_num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_soma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_num1;
        private System.Windows.Forms.TextBox text_num2;
        private System.Windows.Forms.TextBox text_resultado;
        private System.Windows.Forms.TextBox text_num3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bnt_mult;
        private System.Windows.Forms.Button bnt_div;
        private System.Windows.Forms.Button bnt_sub;
    }
}

