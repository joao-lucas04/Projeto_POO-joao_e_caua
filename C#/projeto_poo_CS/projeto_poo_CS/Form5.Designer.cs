namespace projeto_poo_CS
{
    partial class form_tabuadawhile
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
            this.btn_volt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(296, 97);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(95, 13);
            this.lbl_num.TabIndex = 0;
            this.lbl_num.Text = "Digite um número: ";
            // 
            // lbl_tabu
            // 
            this.lbl_tabu.AutoSize = true;
            this.lbl_tabu.Location = new System.Drawing.Point(305, 165);
            this.lbl_tabu.Name = "lbl_tabu";
            this.lbl_tabu.Size = new System.Drawing.Size(86, 13);
            this.lbl_tabu.TabIndex = 1;
            this.lbl_tabu.Text = "A Tabuada será:";
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(397, 94);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(100, 20);
            this.txt_num.TabIndex = 2;
            // 
            // txt_tabu
            // 
            this.txt_tabu.Location = new System.Drawing.Point(397, 162);
            this.txt_tabu.Multiline = true;
            this.txt_tabu.Name = "txt_tabu";
            this.txt_tabu.Size = new System.Drawing.Size(100, 192);
            this.txt_tabu.TabIndex = 3;
            // 
            // btn_lim
            // 
            this.btn_lim.Location = new System.Drawing.Point(207, 378);
            this.btn_lim.Name = "btn_lim";
            this.btn_lim.Size = new System.Drawing.Size(75, 23);
            this.btn_lim.TabIndex = 4;
            this.btn_lim.Text = "Limpar";
            this.btn_lim.UseVisualStyleBackColor = true;
            this.btn_lim.Click += new System.EventHandler(this.btn_lim_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(406, 378);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(75, 23);
            this.btn_cal.TabIndex = 5;
            this.btn_cal.Text = "Calcular";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // btn_volt
            // 
            this.btn_volt.Location = new System.Drawing.Point(604, 378);
            this.btn_volt.Name = "btn_volt";
            this.btn_volt.Size = new System.Drawing.Size(75, 23);
            this.btn_volt.TabIndex = 6;
            this.btn_volt.Text = "Voltar";
            this.btn_volt.UseVisualStyleBackColor = true;
            this.btn_volt.Click += new System.EventHandler(this.btn_volt_Click);
            // 
            // form_tabuadawhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volt);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_lim);
            this.Controls.Add(this.txt_tabu);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_tabu);
            this.Controls.Add(this.lbl_num);
            this.Name = "form_tabuadawhile";
            this.Text = "Tabuada com while";
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
        private System.Windows.Forms.Button btn_volt;
    }
}