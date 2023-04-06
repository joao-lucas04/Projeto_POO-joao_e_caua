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
    public partial class form_comb : Form
    {
        public form_comb()
        {
            InitializeComponent();
        }

        private void txt__TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_com_Click(object sender, EventArgs e)
        {

        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            double quant, V1, V2;
            char cod;

            cod = Convert.ToChar(txt_com.Text);
            quant = Convert.ToDouble(txt_quant.Text);

            if (cod == 'A')
            {
                if (quant <= 20)
                {
                    V1 = 4.90 - (4.90 * 3) / 100;
                    V2 = V1 * quant;

                    txt_pay.Text = V2.ToString();
                }
                else 
                {
                    V1 = 4.90 - (4.90 * 5) / 100;
                    V2 = V1 * quant;

                    txt_pay.Text = V2.ToString();
                }

            } 
            else if(cod == 'G')
            {
                if (quant <= 20)
                {
                    V1 = 5.50 - (5.50 * 4) / 100;
                    V2 = V1 * quant;

                    txt_pay.Text = V2.ToString();
                }
                else
                {
                    V1 = 5.50 - (5.50 * 6) / 100;
                    V2 = V1 * quant;

                    txt_pay.Text = V2.ToString();
                }
            }
        }

        private void form_vot_Load(object sender, EventArgs e)
        {
            this.Hide();
            form_menu frm = new form_menu();
            frm.Show();
        }

        private void btn_lim_Click(object sender, EventArgs e)
        {
            txt_quant.Clear();
            txt_com.Clear();
            txt_pay.Clear();

            txt_com.Focus();
        }

        private void txt_pay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_volt_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_menu frm = new form_menu();
            frm.Show();
        }

        private void txt_quant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
