namespace projeto_poo_CS
{
    partial class form_tabudo_while
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
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_tabu = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.txt_tabu = new System.Windows.Forms.TextBox();
            this.btn_lim = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.btn_vol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(264, 61);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(92, 13);
            this.lbl_num.TabIndex = 0;
            this.lbl_num.Text = "Digite um número:";
            // 
            // lbl_tabu
            // 
            this.lbl_tabu.AutoSize = true;
            this.lbl_tabu.Location = new System.Drawing.Point(284, 124);
            this.lbl_tabu.Name = "lbl_tabu";
            this.lbl_tabu.Size = new System.Drawing.Size(72, 13);
            this.lbl_tabu.TabIndex = 1;
            this.lbl_tabu.Text = "A Tabuada é:";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(362, 58);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 2;
            // 
            // txt_tabu
            // 
            this.txt_tabu.Location = new System.Drawing.Point(362, 121);
            this.txt_tabu.Multiline = true;
            this.txt_tabu.Name = "txt_tabu";
            this.txt_tabu.Size = new System.Drawing.Size(100, 180);
            this.txt_tabu.TabIndex = 3;
            this.txt_tabu.TextChanged += new System.EventHandler(this.txt_tabu_TextChanged);
            // 
            // btn_lim
            // 
            this.btn_lim.Location = new System.Drawing.Point(184, 330);
            this.btn_lim.Name = "btn_lim";
            this.btn_lim.Size = new System.Drawing.Size(75, 23);
            this.btn_lim.TabIndex = 4;
            this.btn_lim.Text = "Limpar";
            this.btn_lim.UseVisualStyleBackColor = true;
            this.btn_lim.Click += new System.EventHandler(this.btn_lim_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(362, 330);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 5;
            this.btn_cal.Text = "Calcular";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_vol
            // 
            this.btn_vol.Location = new System.Drawing.Point(542, 330);
            this.btn_vol.Name = "btn_vol";
            this.btn_vol.Size = new System.Drawing.Size(75, 23);
            this.btn_vol.TabIndex = 6;
            this.btn_vol.Text = "Voltar";
            this.btn_vol.UseVisualStyleBackColor = true;
            this.btn_vol.Click += new System.EventHandler(this.btn_vol_Click);
            // 
            // form_tabudo_while
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_vol);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_lim);
            this.Controls.Add(this.txt_tabu);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_tabu);
            this.Controls.Add(this.lbl_num);
            this.Name = "form_tabudo_while";
            this.Text = "Tabuada com do-While";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_tabu;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.TextBox txt_tabu;
        private System.Windows.Forms.Button btn_lim;
        private System.Windows.Forms.Button btn_cal;
        private System.Windows.Forms.Button btn_vol;
    }
}