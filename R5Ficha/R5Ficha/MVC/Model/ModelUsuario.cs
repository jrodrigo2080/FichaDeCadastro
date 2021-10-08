using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R5Ficha.MVC.Model
{
    public class ModelUsuario
    {   
        public static void InserirUsuario(string nome,string senha)
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    con.Open();
                    var sql = $"INSERT INTO USUARIO(NOME,SENHA)VALUES('"+ nome+"','"+senha+"')";
                    FbCommand comando = new FbCommand(sql, con);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuário salvo com Sucesso!");
                }catch(Exception e)
                {
                    MessageBox.Show("Erro ao Salvar "+e.Message);
                }
                finally
                {
                    con.Close();
                }

            }
        }
        public static void GetUsuario(DataGridView tabela)
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    con.Open();
                    var sql = "select id_usuario as CODIGO, nome as NOME, senha AS SENHA from USUARIO";
                    FbCommand comando = new FbCommand(sql, con);
                    FbDataAdapter dataAdapter = new FbDataAdapter(comando);
                    DataTable lista = new DataTable();
                    dataAdapter.Fill(lista);
                    tabela.DataSource = lista;
                }
                catch(Exception e){ MessageBox.Show("Erro ao Listar " + e.Message);}
                finally { con.Close(); }

            }
        }
        public static void UpdateUsuario(string nome, string senha, string codigo)
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    con.Open();
                    var sql = $"UPDATE USUARIO SET NOME = '{nome}',SENHA = '{senha}' WHERE ID_USUARIO = '{codigo}'";
                    FbCommand comando = new FbCommand(sql, con);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Informações alteradas com Sucesso!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao Alterar " + e.Message);
                }
                finally
                {
                    con.Close();
                }

            }
        }
        public static void DeleteUsuario(string codigo)
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    con.Open();
                    var sql = $"DELETE FROM USUARIO WHERE ID_USUARIO = '{codigo}'";
                    FbCommand comando = new FbCommand(sql, con);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuário deletado com sucesso!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao Alterar " + e.Message);
                }
                finally
                {
                    con.Close();
                }

            }
        }      

    }
}
