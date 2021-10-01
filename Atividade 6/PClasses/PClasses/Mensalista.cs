using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Mensalista : Empregado
    {
        public double  SalarioMensal { get; set; }

        public Mensalista()
        {

        }

        public Mensalista(int matx, string nomex, DateTime datax,
        double salx)
        {
            this.NomeDoEmpregado = nomex;
            this.Matricula = matx;
            this.DataDaEmpresa = datax;
            this.SalarioMensal = salx;
        }

        public Mensalista(int a)
        {

        }
        public override double SalarioBruto()
        {
            return SalarioMensal;   

        }

        public int soma(int x, int y)
        {
            return x + y;
        }
    }
}
