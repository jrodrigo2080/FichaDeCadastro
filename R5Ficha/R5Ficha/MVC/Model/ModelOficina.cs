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
    public class ModelOficina
    {
        public static void InserirOficina(string nome)
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    con.Open();
                    var sql = $"INSERT INTO OFICINA(NOME)VALUES('" + nome + "')";
                    FbCommand comando = new FbCommand(sql, con);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Oficina Cadastrada com Sucesso!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao Salvar " + e.Message);
                }
                finally
                {
                    con.Close();
                }

            }
        }
        public static void GetOficina(DataGridView tabela)
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    con.Open();
                    var sql = "select id_oficina as CODIGO, nome as NOME from OFICINA";
                    FbCommand comando = new FbCommand(sql, con);
                    FbDataAdapter dataAdapter = new FbDataAdapter(comando);
                    DataTable lista = new DataTable();
                    dataAdapter.Fill(lista);
                    tabela.DataSource = lista;
                }
                catch (Exception e) { MessageBox.Show("Erro ao Listar " + e.Message); }
                finally { con.Close(); }

            }
        }
        public static void UpdateOficina(string nome,string codigo)
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    if (codigo != null || codigo != "")
                    {
                        con.Open();
                        var sql = $"UPDATE OFICINA SET NOME = '{nome}' WHERE ID_OFICINA = '{codigo}'";
                        FbCommand comando = new FbCommand(sql, con);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Informações alteradas com Sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma oficina para deletar!");
                    }
                    
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
        public static void DeleteOficina(string codigo)
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    if (codigo != null || codigo != "")
                    {
                        con.Open();
                        var sql = $"DELETE FROM OFICINA WHERE ID_OFICINA = '{codigo}'";
                        FbCommand comando = new FbCommand(sql, con);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Oficina deletada com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma oficina para deletar!");
                    }                  
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
