using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PContato0030482113001
{
    class Contato
    {
        /*
        private int idContato;
        private string nomeContato;
        private string endContato;
        private int cidadeIdCidade;
        private string celContato;
        private string emailContato;
        private DateTime dtCadastroContato;
        */


        public int Idcontato { get; set; }

        public string Nomecontato { get; set; }

        public string Endcontato { get; set; }

        public int Cidadeidcontato { get; set; }

        public string Celcontato { get; set; }

        public string Emailcontato { get; set; }

        public DateTime Dtcadastrocontato { get; set; }


        //metodos

        public DataTable Listar()
        {
            SqlDataAdapter daContato;

            DataTable dtContato = new DataTable();

            try
            {
                daContato = new SqlDataAdapter("SELECT * FROM CONTATO", frmPrincipal.conexao);
                daContato.Fill(dtContato);
                daContato.FillSchema(dtContato, SchemaType.Source);
            }

            catch (Exception)
            {
                throw;
            }
            return dtContato;
        }

        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("INSERT INTO CONTATO VALUES (@nomecontato,@endcontato,@cidadeidcidade,@celcontato,@emailcontato,@dtcadastrocontato)", frmPrincipal.conexao); 
               
                mycommand.Parameters.Add(new SqlParameter("@nomecontato", SqlDbType.VarChar)); 
                mycommand.Parameters.Add(new SqlParameter("@endcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeidcidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@celcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@emailcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastrocontato", SqlDbType.Date));


                mycommand.Parameters["@nomecontato"].Value = Nomecontato;
                mycommand.Parameters["@endcontato"].Value = Endcontato;
                mycommand.Parameters["@cidadeidcidade"].Value = Cidadeidcontato;
                mycommand.Parameters["@celcontato"].Value = Celcontato;
                mycommand.Parameters["@emailcontato"].Value = Emailcontato;
                mycommand.Parameters["@dtcadastrocontato"].Value = Dtcadastrocontato;


                retorno = mycommand.ExecuteNonQuery();
                

            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("UPDATE CONTATO SET NOME_CONTATO = @nomeconato, END_CONTATO = @endcontato" +
                    "CIDADE_CONTATO = @cidadeidcidade , CEL_CONTATO = @celcontato, EMAIL_CONTATO = @emailcontato" +
                    "DTCADASTRO_CONTATO = @dtcadastrocontato WHERE ID_CONTATO = @idcontato", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@idcontato", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nomecontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@endcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeidcidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@celcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@emailcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastrocontato", SqlDbType.Date));

                mycommand.Parameters["@idcontato"].Value = Idcontato;
                mycommand.Parameters["@nomecontato"].Value = Nomecontato;
                mycommand.Parameters["@endcontato"].Value = Endcontato;
                mycommand.Parameters["@cidadeidcidade"].Value = Cidadeidcontato;
                mycommand.Parameters["@celcontato"].Value = Celcontato;
                mycommand.Parameters["@emailcontato"].Value = Emailcontato;
                mycommand.Parameters["@dtcadastrocontato"].Value = Dtcadastrocontato;


                retorno = mycommand.ExecuteNonQuery();
               
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        public int Excluir()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("DELETE FROM CONTATO WHERE ID_CONTATO = @idcontato", frmPrincipal.conexao); 
               
                mycommand.Parameters.Add(new SqlParameter("@idcontato", SqlDbType.Int));
                mycommand.Parameters["@idcontato"].Value =Convert.ToInt16(Idcontato);
                retorno = mycommand.ExecuteNonQuery();
            }

            catch (Exception)
            {
                throw ;
            }
            return retorno;
        }



    }
} 
