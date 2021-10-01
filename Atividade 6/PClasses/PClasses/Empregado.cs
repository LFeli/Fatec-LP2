using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract class Empregado
    {
        private int matricula;
        private string nomeEmpregado;
        private DateTime dataDaEmresa;

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string NomeDoEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataDaEmpresa
        {
            get { return DataDaEmpresa; }
            set { DataDaEmpresa = value; }
        }

        public virtual int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract(DataDaEmpresa);
                return (span.Days);
        }

        public abstract double SalarioBruto();
    }
}
