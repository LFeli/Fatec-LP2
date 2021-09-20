using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_Salário_Bruto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtNumFilhos.Clear();
            txtNomeFunci.Clear();
            txtSalaBrut.Clear();
            txtSalaFml.Clear();
            txtDescIPRF.Clear();
            txtDescINSS.Clear();
            txtAluiqIPRF.Clear();
            txtAliqINSS.Clear();
            txtSalaLiquido.Clear();
        }

        private void btnCalcu_Click(object sender, EventArgs e)
        {
            double SalarioBruto;
            double NumFilhos;
            double SalaFml = 0;
            double DescINSS;
            double DescIPRF;
            double SalarioLiquido;

            string AliqINSS;
            string AliqIPRF;

            if ((double.TryParse(txtSalaBrut.Text, out SalarioBruto)) &&
                (double.TryParse(txtNumFilhos.Text, out NumFilhos)))
            {
                if(SalarioBruto == 0 && NumFilhos == 0)
                {
                    MessageBox.Show("Valores Invalidos");
                }
                else 

                //Calculo Salario familia
                if (SalarioBruto <= 435.52)
                    SalaFml = 22.23 * NumFilhos;
                else if (SalarioBruto <= 654.61)
                    SalaFml = 15.74 * NumFilhos ;

                txtSalaFml.Text = SalaFml.ToString("N2");   

            }
            else
                MessageBox.Show("Valores invalidos");

            //Calculo Desconto INSS 

            if (SalarioBruto <= 800.47)
                DescINSS = SalarioBruto * 0.0765;
            else if (SalarioBruto <= 1050)
                DescINSS = SalarioBruto * 0.0865;
            else if (SalarioBruto <= 1400.77)
                DescINSS = SalarioBruto * 0.09;
            else if (SalarioBruto <= 2801.56)
                DescINSS = SalarioBruto * 0.11;
            else
                DescINSS = 308.17;

                    txtDescINSS.Text = DescINSS.ToString("N2");

            //Calculo Desconto IPRF

            if (SalarioBruto <= 1257.12)
                DescIPRF = SalarioBruto * 0;
            else if (SalarioBruto <= 2512.08)
                DescIPRF = SalarioBruto * 0.15;
            else 
                DescIPRF = SalarioBruto * 0.275;

            txtDescIPRF.Text = DescIPRF.ToString("N2");

            //Aliquota INSS
            if (SalarioBruto <= 800.47)
                AliqINSS = "7.65%";
            else if (SalarioBruto <= 1050)
                AliqINSS = "8.65%";
            else if (SalarioBruto <= 1400.77)
                AliqINSS = "9%";
            else if (SalarioBruto <= 2801.56)
                AliqINSS = "11%";
            else
                AliqINSS = "Teto";

            txtAliqINSS.Text = AliqINSS;

            //Aliquota IPRF
            if (SalarioBruto <= 1257.12)
                AliqIPRF = "Insento";
            else if (SalarioBruto <= 2512.08)
                AliqIPRF = "15%";
            else
                AliqIPRF = "27,5%";

            txtAluiqIPRF.Text = AliqIPRF;

            //Salario Liquido
            SalarioLiquido = SalarioBruto - DescINSS - DescIPRF + SalaFml;
            txtSalaLiquido.Text = SalarioLiquido.ToString("N2");

            //Mensagem
            
        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }
    }
}
