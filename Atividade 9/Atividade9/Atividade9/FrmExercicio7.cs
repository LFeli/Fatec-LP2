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
    public partial class FrmExercicio7 : Form
    {
        public FrmExercicio7()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string InputPalavra = Interaction.InputBox("Fala o nome do pião", "Entrada de dado");
            string[] nome = new string[] { InputPalavra }; 
            int tamanho = 0;

            InputPalavra = InputPalavra.Replace(" ", "");
            tamanho = InputPalavra.Length;

            listBox1.Items.Insert(0, "O nome : " + nome[0] + " tem " + tamanho.ToString() + " letras");





        }
    }
}
