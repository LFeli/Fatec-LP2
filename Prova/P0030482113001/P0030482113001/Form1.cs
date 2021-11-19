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

namespace P0030482113001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFuncao_Click(object sender, EventArgs e)
        {
            double[,] vetor = new double[1, 4];
            string semana = "";
            double valorSemana = 0;
            double valorMes = 0;
            double valorGeral = 0;


            for ( int i = 0; i < 1;i++)
            {
                for ( int j = 0; j < 4; j++)
                {
                    semana = Interaction.InputBox("Entre com o valor da semana: " + (j + 1).ToString(), "Entrada de dados");

                    if (semana == "")
                        break;

                        if (double.TryParse(semana, out vetor[i, j]))
                        {
                            valorSemana = vetor[i, j];
                            valorMes += vetor[i, j];
                        }
                            valorGeral += valorSemana;

                    lstbxEntrada.Items.Insert(0, "Total do mês " + (i + 1).ToString() + " Semana " + (j + 1).ToString() + " " + valorSemana.ToString("C2"));
                }
                    lstbxEntrada.Items.Insert(0, "------------------------------------------------------");
                    lstbxEntrada.Items.Insert(0,">> " + "Total do mês "  + " " + valorMes.ToString("C2"));
                    lstbxEntrada.Items.Insert(0, "------------------------------------------------------");
                    lstbxEntrada.Items.Insert(0,">> " + "Total geral " + " " + valorGeral.ToString("C2"));
                    lstbxEntrada.Items.Insert(0,"------------------------------------------------------");
            }
        }
    }
}
