using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R5Ficha.MVC.Model
{
    public class ModelConexao
    {
        private static readonly ModelConexao Instancia = new ModelConexao();

        private ModelConexao() { }

        public static ModelConexao GetInstancia()
        {
            return Instancia;
        }

        public FbConnection GetConexao()
        {
            string con = ConfigurationManager.ConnectionStrings["StringConexao"].ToString();
            return new FbConnection(con);
        }

        public static bool testaConexao()
        {
            bool resposta = true;

            using (FbConnection con = Instancia.GetConexao())
            {
                try
                {
                    con.Open();
                    MessageBox.Show("Certo");
                }
                catch(Exception e)
                {
                    resposta = false;
                    MessageBox.Show("Erro "+e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return resposta;
        }

    }
}
