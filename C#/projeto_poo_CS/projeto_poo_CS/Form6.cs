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
    public partial class form_tabudo_while : Form
    {
        public form_tabudo_while()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            int i = 0;
            double X, num;

            num = Convert.ToDouble(txt_num.Text);

            do
            {
                X = num * i;

                txt_tabu.Text = String.Concat(txt_tabu.Text, "\r\n", num.ToString() + "x" + i.ToString() + "=" + X.ToString());

                i++;

            } while (i < 11);
        }

        private void txt_tabu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_lim_Click(object sender, EventArgs e)
        {
            txt_num.Clear();
            txt_tabu.Clear();

            txt_num.Focus();

        }

        private void btn_vol_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_menu fn = new form_menu();
            fn.Show();
        }
    }
}
