using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade9
{
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string[] alunos = {"Viviane","André","Hélio","Denise","Junior","Leonardo","Jose","Nelma","Tobby"};
                Int32 I, Total = 0;
                Int32 N = alunos.Length;
                for (I = 0;I < N- 1; I++)
                {
                    Total += alunos[I].Length;
                }
            MessageBox.Show(Total.ToString()); /* Resultado deu 46*/
        }
    }
}
