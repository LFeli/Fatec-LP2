using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Microsoft.VisualBasic;

namespace Atividade9
{
    public partial class FrmExercicio6 : Form
    {
        public FrmExercicio6()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            double[,] vetor = new double[20, 3];
            double media = 0;
            double aluno = 0;

            string valor = "";

            for (int x = 0; x < 20; x++)
            {
                
                for (int i = 0; i < 3; i++)
                {
                    valor = Interaction.InputBox("Entre com a nota da disciplina: " + (i + 1).ToString(), "Entrada de dados");

                    if (valor == "")
                    {
                        break;
                    }
                    if (double.TryParse(valor, out vetor[x, i]))
                    {
                        if ( vetor[x,i] >= 0 && vetor[x, i] <= 10)
                        {
                            media += vetor[x, i];
                        }
                        else
                        {
                            MessageBox.Show("Por favor verifique novamente o valor das notas");
                            i--;
                        }
                    }
                    else
                        MessageBox.Show("Valor invalido");
                    
                    
                }
                aluno += 1;
                listBox1.Items.Insert(0, "O Aluno " + aluno.ToString() + " teve uma media de :" + (media / 3).ToString("N2"));
                media -= media;
            }
        }
    }
}
