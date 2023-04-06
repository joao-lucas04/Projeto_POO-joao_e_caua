using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_poo_CS
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void votaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_comb fn=new form_comb();
            fn.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void votaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_vot fn = new form_vot();
            fn.Show();
        }

        private void tabuadaComParaforToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_tabuadafor fn = new form_tabuadafor();
            fn.Show();
        }

        private void tabuadaComWhileenquantoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_tabuadawhile fn = new form_tabuadawhile();
            fn.Show();
        }

        private void tabuadaComDowhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_tabudo_while fn = new form_tabudo_while();
            fn.Show();
        }
    }
}
