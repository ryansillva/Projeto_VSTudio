using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulações_para_a_prova
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            double peso = double.Parse(txtBox1.Text);
            double altura = double.Parse(txtBox2.Text); 
            double imc = peso / (altura * altura);

            txtPesoIdeal.Text = imc.ToString();

              if (rbHomem.Checked)
            {
                double PesoIdealHomem = 22 * (altura  * altura);
                
            }
              else if (rbMulher.Checked)
            {
                double PesoIdealMulher = 21 * (altura * altura);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
