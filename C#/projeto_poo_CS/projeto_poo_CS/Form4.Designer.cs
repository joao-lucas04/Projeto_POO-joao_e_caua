namespace projeto_poo_CS
{
    partial class form_vot
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
            this.lbl_VJS = new System.Windows.Forms.Label();
            this.lbl_VMJ = new System.Windows.Forms.Label();
            this.lbl_VJT = new System.Windows.Forms.Label();
            this.lbl_situacao = new System.Windows.Forms.Label();
            this.txt_VJS = new System.Windows.Forms.TextBox();
            this.txt_VMJ = new System.Windows.Forms.TextBox();
            this.txt_VJT = new System.Windows.Forms.TextBox();
            this.txt_situacao = new System.Windows.Forms.TextBox();
            this.btn_lim = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_volt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_VJS
            // 
            this.lbl_VJS.AutoSize = true;
            this.lbl_VJS.Location = new System.Drawing.Point(262, 57);
            this.lbl_VJS.Name = "lbl_VJS";
            this.lbl_VJS.Size = new System.Drawing.Size(118, 13);
            this.lbl_VJS.TabIndex = 0;
            this.lbl_VJS.Text = "Votos do José da Silva:";
            // 
            // lbl_VMJ
            // 
            this.lbl_VMJ.AutoSize = true;
            this.lbl_VMJ.Location = new System.Drawing.Point(262, 107);
            this.lbl_VMJ.Name = "lbl_VMJ";
            this.lbl_VMJ.Size = new System.Drawing.Size(118, 13);
            this.lbl_VMJ.TabIndex = 1;
            this.lbl_VMJ.Text = "Votos de Maria Jurema:";
            this.lbl_VMJ.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_VJT
            // 
            this.lbl_VJT.AutoSize = true;
            this.lbl_VJT.Location = new System.Drawing.Point(245, 164);
            this.lbl_VJT.Name = "lbl_VJT";
            this.lbl_VJT.Size = new System.Drawing.Size(135, 13);
            this.lbl_VJT.TabIndex = 2;
            this.lbl_VJT.Text = "Votos de João da Tapioca:";
            // 
            // lbl_situacao
            // 
            this.lbl_situacao.AutoSize = true;
            this.lbl_situacao.Location = new System.Drawing.Point(173, 240);
            this.lbl_situacao.Name = "lbl_situacao";
            this.lbl_situacao.Size = new System.Drawing.Size(52, 13);
            this.lbl_situacao.TabIndex = 3;
            this.lbl_situacao.Text = "Situação:";
            this.lbl_situacao.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_VJS
            // 
            this.txt_VJS.Location = new System.Drawing.Point(386, 57);
            this.txt_VJS.Name = "txt_VJS";
            this.txt_VJS.Size = new System.Drawing.Size(100, 20);
            this.txt_VJS.TabIndex = 4;
            // 
            // txt_VMJ
            // 
            this.txt_VMJ.Location = new System.Drawing.Point(386, 107);
            this.txt_VMJ.Name = "txt_VMJ";
            this.txt_VMJ.Size = new System.Drawing.Size(100, 20);
            this.txt_VMJ.TabIndex = 5;
            // 
            // txt_VJT
            // 
            this.txt_VJT.Location = new System.Drawing.Point(386, 161);
            this.txt_VJT.Name = "txt_VJT";
            this.txt_VJT.Size = new System.Drawing.Size(100, 20);
            this.txt_VJT.TabIndex = 6;
            // 
            // txt_situacao
            // 
            this.txt_situacao.Location = new System.Drawing.Point(231, 240);
            this.txt_situacao.Multiline = true;
            this.txt_situacao.Name = "txt_situacao";
            this.txt_situacao.Size = new System.Drawing.Size(380, 50);
            this.txt_situacao.TabIndex = 7;
            // 
            // btn_lim
            // 
            this.btn_lim.Location = new System.Drawing.Point(231, 345);
            this.btn_lim.Name = "btn_lim";
            this.btn_lim.Size = new System.Drawing.Size(75, 23);
            this.btn_lim.TabIndex = 8;
            this.btn_lim.Text = "Limpar";
            this.btn_lim.UseVisualStyleBackColor = true;
            this.btn_lim.Click += new System.EventHandler(this.btn_lim_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(386, 345);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 9;
            this.btn_cal.Text = "Calcular";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click_2);
            // 
            // btn_volt
            // 
            this.btn_volt.Location = new System.Drawing.Point(536, 345);
            this.btn_volt.Name = "btn_volt";
            this.btn_volt.Size = new System.Drawing.Size(75, 23);
            this.btn_volt.TabIndex = 10;
            this.btn_volt.Text = "Voltar";
            this.btn_volt.UseVisualStyleBackColor = true;
            this.btn_volt.Click += new System.EventHandler(this.btn_volt_Click);
            // 
            // form_vot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volt);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_lim);
            this.Controls.Add(this.txt_situacao);
            this.Controls.Add(this.txt_VJT);
            this.Controls.Add(this.txt_VMJ);
            this.Controls.Add(this.txt_VJS);
            this.Controls.Add(this.lbl_situacao);
            this.Controls.Add(this.lbl_VJT);
            this.Controls.Add(this.lbl_VMJ);
            this.Controls.Add(this.lbl_VJS);
            this.Name = "form_vot";
            this.Text = "Votação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_VJS;
        private System.Windows.Forms.Label lbl_VMJ;
        private System.Windows.Forms.Label lbl_VJT;
        private System.Windows.Forms.Label lbl_situacao;
        private System.Windows.Forms.TextBox txt_VJS;
        private System.Windows.Forms.TextBox txt_VMJ;
        private System.Windows.Forms.TextBox txt_VJT;
        private System.Windows.Forms.TextBox txt_situacao;
        private System.Windows.Forms.Button btn_lim;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_volt;
    }
}