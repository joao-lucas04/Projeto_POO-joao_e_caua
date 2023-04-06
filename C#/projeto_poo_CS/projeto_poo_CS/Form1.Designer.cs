namespace projeto_poo_CS
{
    partial class form_menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votaçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaComParaforToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaComWhileenquantoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaComDowhileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.votaçãoToolStripMenuItem,
            this.votaçãoToolStripMenuItem1,
            this.tabuadaComParaforToolStripMenuItem,
            this.tabuadaComWhileenquantoToolStripMenuItem,
            this.tabuadaComDowhileToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.programasToolStripMenuItem.Text = "Programas -_-";
            // 
            // votaçãoToolStripMenuItem
            // 
            this.votaçãoToolStripMenuItem.Name = "votaçãoToolStripMenuItem";
            this.votaçãoToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.votaçãoToolStripMenuItem.Text = "Posto do JL e CM";
            this.votaçãoToolStripMenuItem.Click += new System.EventHandler(this.votaçãoToolStripMenuItem_Click);
            // 
            // votaçãoToolStripMenuItem1
            // 
            this.votaçãoToolStripMenuItem1.Name = "votaçãoToolStripMenuItem1";
            this.votaçãoToolStripMenuItem1.Size = new System.Drawing.Size(238, 22);
            this.votaçãoToolStripMenuItem1.Text = "Votação";
            this.votaçãoToolStripMenuItem1.Click += new System.EventHandler(this.votaçãoToolStripMenuItem1_Click);
            // 
            // tabuadaComParaforToolStripMenuItem
            // 
            this.tabuadaComParaforToolStripMenuItem.Name = "tabuadaComParaforToolStripMenuItem";
            this.tabuadaComParaforToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.tabuadaComParaforToolStripMenuItem.Text = "Tabuada com para ";
            this.tabuadaComParaforToolStripMenuItem.Click += new System.EventHandler(this.tabuadaComParaforToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tabuadaComWhileenquantoToolStripMenuItem
            // 
            this.tabuadaComWhileenquantoToolStripMenuItem.Name = "tabuadaComWhileenquantoToolStripMenuItem";
            this.tabuadaComWhileenquantoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.tabuadaComWhileenquantoToolStripMenuItem.Text = "Tabuada com while";
            this.tabuadaComWhileenquantoToolStripMenuItem.Click += new System.EventHandler(this.tabuadaComWhileenquantoToolStripMenuItem_Click);
            // 
            // tabuadaComDowhileToolStripMenuItem
            // 
            this.tabuadaComDowhileToolStripMenuItem.Name = "tabuadaComDowhileToolStripMenuItem";
            this.tabuadaComDowhileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.tabuadaComDowhileToolStripMenuItem.Text = "Tabuada com do-while";
            this.tabuadaComDowhileToolStripMenuItem.Click += new System.EventHandler(this.tabuadaComDowhileToolStripMenuItem_Click);
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_menu";
            this.Text = "Menu ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votaçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tabuadaComParaforToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaComWhileenquantoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaComDowhileToolStripMenuItem;
    }
}

