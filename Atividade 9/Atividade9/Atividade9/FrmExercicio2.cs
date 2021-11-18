using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade9
{
    public partial class FrmExercicio2 : Form
    {
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            double[] mercadoria = new double[10];
            double[] valorProduto = new double[10];

            string quantidade = "";
            string valor = "";

            double quantFinal = 0;
            double valorFinal = 0;

            double FaturamenteMensal = 0;
            double tst = 0;

            for(int i = 0; i < 10; i++)
            {
                quantidade = Interaction.InputBox("Entre com a quantidade do produto: " + (i + 1).ToString(), "Entrada de dados");

                if ( quantidade == "")
                    break;
                if (double.TryParse(quantidade, out mercadoria[i]))
                {
                    quantFinal = mercadoria[i];
                }
                else
                    MessageBox.Show("Valor invalido");

                    for (int j = 0; j < 1; j++)
                    {
                        valor = Interaction.InputBox("Entre com o valor do produto: " + (i + 1).ToString(), "Entrada de dados");
                        if (valor == "")
                            break;
                        if (double.TryParse(valor, out valorProduto[j]))
                        {
                            valorFinal = valorProduto[j];
                        }
                        else
                            MessageBox.Show("Valor invalido");

                    tst = quantFinal * valorFinal;
                    FaturamenteMensal += tst;

                }
                
            }
            MessageBox.Show("O faturamento bruto será " + FaturamenteMensal.ToString());
        }
    }
}
