namespace projeto_poo_CS
{
    partial class form_comb
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
            this.lbl_com = new System.Windows.Forms.Label();
            this.txt_com = new System.Windows.Forms.TextBox();
            this.lbl_quant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.btn_lim = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_volt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_com
            // 
            this.lbl_com.AutoSize = true;
            this.lbl_com.Location = new System.Drawing.Point(229, 143);
            this.lbl_com.Name = "lbl_com";
            this.lbl_com.Size = new System.Drawing.Size(142, 13);
            this.lbl_com.TabIndex = 0;
            this.lbl_com.Text = "Digite o tipo de combustível:";
            this.lbl_com.Click += new System.EventHandler(this.lbl_com_Click);
            // 
            // txt_com
            // 
            this.txt_com.Location = new System.Drawing.Point(377, 143);
            this.txt_com.Name = "txt_com";
            this.txt_com.Size = new System.Drawing.Size(100, 20);
            this.txt_com.TabIndex = 1;
            this.txt_com.TextChanged += new System.EventHandler(this.txt__TextChanged);
            // 
            // lbl_quant
            // 
            this.lbl_quant.AutoSize = true;
            this.lbl_quant.Location = new System.Drawing.Point(226, 192);
            this.lbl_quant.Name = "lbl_quant";
            this.lbl_quant.Size = new System.Drawing.Size(145, 13);
            this.lbl_quant.TabIndex = 2;
            this.lbl_quant.Text = "Digite a quantidade de Litros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor a pagar:";
            // 
            // txt_quant
            // 
            this.txt_quant.Location = new System.Drawing.Point(377, 192);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(100, 20);
            this.txt_quant.TabIndex = 4;
            // 
            // txt_pay
            // 
            this.txt_pay.Location = new System.Drawing.Point(377, 235);
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.Size = new System.Drawing.Size(100, 20);
            this.txt_pay.TabIndex = 5;
            this.txt_pay.TextChanged += new System.EventHandler(this.txt_pay_TextChanged);
            // 
            // btn_lim
            // 
            this.btn_lim.Location = new System.Drawing.Point(232, 346);
            this.btn_lim.Name = "btn_lim";
            this.btn_lim.Size = new System.Drawing.Size(75, 23);
            this.btn_lim.TabIndex = 6;
            this.btn_lim.Text = "Limpar";
            this.btn_lim.UseVisualStyleBackColor = true;
            this.btn_lim.Click += new System.EventHandler(this.btn_lim_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(393, 346);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 7;
            this.btn_cal.Text = "Calcular";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_volt
            // 
            this.btn_volt.Location = new System.Drawing.Point(550, 346);
            this.btn_volt.Name = "btn_volt";
            this.btn_volt.Size = new System.Drawing.Size(75, 23);
            this.btn_volt.TabIndex = 8;
            this.btn_volt.Text = "Voltar";
            this.btn_volt.UseVisualStyleBackColor = true;
            this.btn_volt.Click += new System.EventHandler(this.btn_volt_Click);
            // 
            // form_comb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volt);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_lim);
            this.Controls.Add(this.txt_pay);
            this.Controls.Add(this.txt_quant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_quant);
            this.Controls.Add(this.txt_com);
            this.Controls.Add(this.lbl_com);
            this.Name = "form_comb";
            this.Text = "Posto do JL e CM";
            this.Load += new System.EventHandler(this.form_vot_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_com;
        private System.Windows.Forms.TextBox txt_com;
        private System.Windows.Forms.Label lbl_quant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.TextBox txt_pay;
        private System.Windows.Forms.Button btn_lim;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_volt;
    }
}