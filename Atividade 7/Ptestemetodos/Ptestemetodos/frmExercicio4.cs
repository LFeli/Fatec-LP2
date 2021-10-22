using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptestemetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int i;
            double qntnums = 0;

            char[] vetorTexto = rtxtInsirir.Text.ToCharArray();

            for (i = 0; i < rtxtInsirir.Text.Length; i++)
            {
                if (char.IsNumber(vetorTexto[i]))
                    qntnums++;
            }
            MessageBox.Show("O texto possui :  " + qntnums.ToString() + "  números");
        }

        private void btnLetras_Click(object sender, EventArgs e)
        {
            {
                int i;
                double qtnletras = 0;

                char[] vetorTexto = rtxtInsirir.Text.ToCharArray();

                for (i = 0; i < rtxtInsirir.Text.Length; i++)
                {
                    if (char.IsLetter(vetorTexto[i]))
                        qtnletras++;
                }
                MessageBox.Show("O texto possui :  " + qtnletras.ToString() + "  letras");
            }
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int i = 0, qtdbranco = 0;
            char[] vetorBranco = rtxtInsirir.Text.ToCharArray();
            bool x = true;

            while (x)
            {
                if (Char.IsWhiteSpace(vetorBranco[i]))
                {
                    qtdbranco = i;
                    x = false;
                }

                i++;
            }
            MessageBox.Show("O  espaço em branco  está na casa número: " + qtdbranco);
        }
    }
}
