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
    public partial class FrmExercicio1 : Form
    {
        public FrmExercicio1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string numeros = "";
            


            for ( int i = 0; i < 5; i++)
            {
                numeros = Interaction.InputBox("Entre com um numero: " + (i + 1).ToString(), "Entrada de dados");
                char[] arr = numeros.ToCharArray();
                Array.Reverse(arr);

                string n = "";
                foreach (char c in arr)
                {
                    n = n + c.ToString();
                }
                




                listBox1.Items.Insert(0, n);
            }
        }
    }
}
