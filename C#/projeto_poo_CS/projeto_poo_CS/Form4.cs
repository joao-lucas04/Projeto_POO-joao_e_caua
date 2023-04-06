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
    public partial class form_vot : Form
    {
        public form_vot()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_cal_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_cal_Click_2(object sender, EventArgs e)
        {
            double VM, VJT, VJS, R, VG, R1;

            VM = Convert.ToDouble(txt_VMJ.Text);
            VJT = Convert.ToDouble(txt_VJT.Text);
            VJS = Convert.ToDouble(txt_VJS.Text);

            VG = VM + VJT + VJS;

            if (VJS > VM)
            {
                R = (VJS / VG)*100;
                R1 = Convert.ToInt32(Math.Floor(R));
                txt_situacao.Text = "De " + VG.ToString() + " votos no total, José da Silva foi o vencedor com " + VJS.ToString() + " desse votos, correspondendo à aproximadamente " + R1.ToString() + "% dos Votos";
            }
            else if (VJT>VM & VJT>VJS){
                R = (VJT / VG) * 100;
                R1 = Convert.ToInt32(Math.Floor(R));
                txt_situacao.Text = "De " + VG.ToString() + " votos no total, João da Tapioca foi o vencedor com " + VJT.ToString() + " desse votos, correspondendo à aproximadamente " + R1.ToString() + "% dos Votos";
            }
            else
            {
                R = (VM / VG) * 100;
                R1 = Convert.ToInt32(Math.Floor(R));
                txt_situacao.Text = "De " + VG.ToString() + " votos no total, Maria Jurema foi o vencedor com " + VM.ToString() + " desse votos, correspondendo à aproximadamente " + R1.ToString() + "% dos Votos";
            }
        }

        private void btn_lim_Click(object sender, EventArgs e)
        {
            txt_situacao.Clear();
            txt_VJS.Clear();
            txt_VJT.Clear();
            txt_VMJ.Clear();

            txt_VJS.Focus();
        }

        private void btn_volt_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_menu fn = new form_menu();
            fn.Show();
        }
    }
}
