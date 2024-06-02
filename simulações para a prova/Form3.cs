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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rbTriangulo.Checked || rbQuadrilatero.Checked || rbCirculo.Checked)
            {
                CalcularPerimetro();
            }
            else
            {
                ExibirErro("Por favor, selecione uma forma geométrica.");
            }
        }

        private void CalcularPerimetro()
        {
            if (rbCirculo.Checked)
            {
                CalcularAreaCirculo();
                return; // Saída precoce da função
            }

            string forma = rbTriangulo.Checked ? "triângulo" : "quadrilátero";
            double[] lados = txtLados.Text.Split(',')
                .Select(side => double.TryParse(side, out double value) ? value : 0)
                .ToArray();

            if (lados.Length == (rbTriangulo.Checked ? 3 : 4) && lados.All(side => side > 0))
            {
                double perimetro = lados.Sum();
                ExibirResultado($"Perímetro do {forma}: {perimetro}");
            }
            else
            {
                ExibirErro($"Por favor, insira valores válidos e positivos para os lados do {forma} separados por vírgula.");
            }
        }

        private void CalcularAreaCirculo()
        {
            if (double.TryParse(txtLados.Text, out double diametro) && diametro > 0)
            {
                double raio = diametro / 2;
                double area = Math.PI * Math.Pow(raio, 2);
                ExibirResultado($"Área do círculo: {area}");
            }
            else
            {
                ExibirErro("Por favor, insira um valor válido e positivo para o diâmetro do círculo.");
            }
        }

        private void ExibirResultado(string mensagem)
        {
            MessageBox.Show(mensagem, "Resultado");
        }

        private void ExibirErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro");
        }

    }
    
}

