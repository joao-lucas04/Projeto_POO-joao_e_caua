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
    public partial class form_tabuadawhile : Form
    {
        public form_tabuadawhile()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            int i = 1;
            double X, num;

            num = Convert.ToDouble(txt_num.Text);

            while (i <= 10)
            {
                X = num * i;

                txt_tabu.Text = String.Concat(txt_tabu.Text, "\r\n", num.ToString() + "x" + i.ToString() + "=" + X.ToString());

                i++;
            }


        }

        private void btn_lim_Click(object sender, EventArgs e)
        {
            txt_num.Clear();
            txt_tabu.Clear();

            txt_num.Focus();
        }

        private void btn_volt_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_menu fn = new form_menu();
            fn.Show();
        }
    }
}
