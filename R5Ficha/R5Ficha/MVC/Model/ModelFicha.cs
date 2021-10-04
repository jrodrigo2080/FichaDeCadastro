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
    public class ModelFicha
    {
             
        public static void InserirFicha(string oficina,
            string inclusao,string data,string atualizacao,string dataCriacao, string nome, string dataNasc,
            string sexo, string nis, string cidade, string uf,string rg,string cpf, string emissor, string telefone,
            string endereco, string cep, string contatoEmergencia, string foneEmergencia, string etnia, string participaGrupo,
            string qualGrupo, string estadoCivil, string religiao, string filhos, string qtsFilhos, string netos, string qtsNetos,
            string indigenas, string reservaIndigenas, string quilombola, string comunidadequilombola, string estrangeiro, string qualPais,
            string escolaridade, string ultimaSerie, string moraComQuem, string aposentado, string situacaoFinanceira, string mediaSalarial,
            string profissao, string moradia, string admFinancia, string admFinanciaTerceiro, string tipoTransporte, string dificuldadeLocomocao,
            string semDificuldadeLocomocao, string baixaVisao, string baixaAudicao, string auxiliomacha, string cego, string surdo, string fuma,
            string bebe, string hipertenso, string cardiaco, string diabetico, string asma, string cancerFamilia, string colesterolElevado,
            string epletico, string depressao, string alergico, string artose, string osteoporose, string renais, string alzheimer, string parkinson,
            string usaMedicamento, string qualMedicamento, string outraDoenca,string atividadeFisica, string qualAtividadeFisica, string autonomia, string situacao, string ufEmissor
            )
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    con.Open();
                    var sql = $"INSERT INTO FICHA (" +
                        $"INCLUSAO,DATA,ATUALIZACAO,DATACRIACAO,NOME,DATANASC,SEXO,NIS," +
                        $"CIDADE,UF,RG,CPF,EMISSOR,TELEFONE,ENDERECO,CEP,CONTATOEMERGENCIA,FONEEMERGENCIA,ETNIA," +
                        $"PARTICIPAGRUPO,QUALGRUPO,ESTADOCIVIL,RELIGIAO,FILHOS,QTSFILHOS,NETOS,QTSNETOS,INDIGENAS,RESERVAINDIGENAS," +
                        $"QUILOMBOLA,COMUNIDADEQUILOMBOLA,ESTRANGEIRO,QUALPAIS,ESCOLARIDADE,ULTIMASERIE,MORACOMQUEM,APOSENTADO,SITUACAOFINANCEIRA," +
                        $"MEDIASALARIAL,PROFISSAO,MORADIA,ADMFINANCA,ADMFINANCATERCEIRO,TIPOTRANSPORTE,DIFICULDADELOCOMOVE,SEMDIFICULDADELOCOMOVE," +
                        $"BAIXAVISAO,BAIXAAUDICAO,AUXILIOMACHA,CEGO,SURDO,FUMA,BEBE,HIPERTENSO,CARDIACO,DIABETICO,ASMA,CANCERFAMILIA,COLESTEROLELEVADO," +
                        $"EPLETICO,DEPRESSAO,ALERGICO,ARTOSE,OSTEOPOROSE,RENAIS,ALZHEIMER,PARKINSON,USAMEDICAMENTO,QUALMEDICAMENTO,OUTRADOENCA,ATIVIDADEFISICA," +
                        $"QUALATIVIDADE,AUTONOMIA,SITUACAO,UFEMISSOR,OFICINA)" +
                        $"VALUES(" +
                        $"'" + inclusao + "','" + data + "','" + atualizacao + "','" + dataCriacao + "','" + nome + "','" + dataNasc + "','" + sexo + "','" + nis + "'," +
                        $"'" + cidade + "','" + uf + "','" + rg + "','" + cpf + "','" + emissor + "','" + telefone + "','" + endereco + "','" + cep + "','" + contatoEmergencia + "','" + foneEmergencia + "','" + etnia + "'," +
                        $"'" + participaGrupo + "','" + qualGrupo + "','" + estadoCivil + "','" + religiao + "','" + filhos + "','" + qtsFilhos + "','" + netos + "','" + qtsNetos + "','" + indigenas + "','" + reservaIndigenas + "'," +
                        $"'" + quilombola + "','" + comunidadequilombola + "','" + estrangeiro + "','" + qualPais + "','" + escolaridade + "','" + ultimaSerie + "','" + moraComQuem + "','" + aposentado + "','" + situacao + "'," +
                        $"'" + mediaSalarial + "','" + profissao + "','" + moradia + "','" + admFinancia + "','" + admFinanciaTerceiro + "','" + tipoTransporte + "','" + dificuldadeLocomocao + "','" + semDificuldadeLocomocao + "'," +
                        $"'" + baixaVisao + "','" + baixaVisao + "','" + auxiliomacha + "','" + cego + "','" + surdo + "','" + fuma + "','" + bebe + "','" + hipertenso + "','" + cardiaco + "','" + diabetico + "','" + asma + "','" + cancerFamilia + "','" + colesterolElevado + "'," +
                        $"'" + epletico + "','" + depressao + "','" + alergico + "','" + artose + "','" + osteoporose + "','" + renais + "','" + alzheimer + "','" + parkinson + "','" + usaMedicamento + "','" + qualMedicamento + "','" + outraDoenca + "','" + atividadeFisica + "'," +
                        $"'" + qualAtividadeFisica + "','" + autonomia + "','" + situacao + "','" + ufEmissor + "','" + oficina+"')";
                        
                    FbCommand comando = new FbCommand(sql, con);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Usuário salvo com Sucesso!");
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


        public static void UpdateFicha(string oficina,
            string inclusao, string data, string atualizacao, string dataCriacao, string nome, string dataNasc,
            string sexo, string nis, string cidade, string uf, string rg, string cpf, string emissor, string telefone,
            string endereco, string cep, string contatoEmergencia, string foneEmergencia, string etnia, string participaGrupo,
            string qualGrupo, string estadoCivil, string religiao, string filhos, string qtsFilhos, string netos, string qtsNetos,
            string indigenas, string reservaIndigenas, string quilombola, string comunidadequilombola, string estrangeiro, string qualPais,
            string escolaridade, string ultimaSerie, string moraComQuem, string aposentado, string situacaoFinanceira, string mediaSalarial,
            string profissao, string moradia, string admFinancia, string admFinanciaTerceiro, string tipoTransporte, string dificuldadeLocomocao,
            string semDificuldadeLocomocao, string baixaVisao, string baixaAudicao, string auxiliomacha, string cego, string surdo, string fuma,
            string bebe, string hipertenso, string cardiaco, string diabetico, string asma, string cancerFamilia, string colesterolElevado,
            string epletico, string depressao, string alergico, string artose, string osteoporose, string renais, string alzheimer, string parkinson,
            string usaMedicamento, string qualMedicamento, string outraDoenca, string atividadeFisica, string qualAtividadeFisica, string autonomia, string situacao, string ufEmissor
            )
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    con.Open();

                    var sql = $"INSERT INTO FICHA(" +
                        $"INCLUSAO,DATA,ATUALIZACAO,DATACRIACAO,NOME,DATANASC,SEXO,NIS," +
                        $"CIDADE,UF,RG,CPF,EMISSOR,TELEFONE,ENDERECO,CEP,CONTATOEMERGENCIA,FONEEMERGENCIA,ETNIA," +
                        $"PARTICIPAGRUPO,QUALGRUPO,ESTADOCIVIL,RELIGIAO,FILHOS,QTSFILHOS,NETOS,QTSNETOS,INDIGENAS,RESERVAINDIGENAS," +
                        $"QUILOMBOLA,COMUNIDADEQUILOMBOLA,ESTRANGEIRO,QUALPAIS,ESCOLARIDADE,ULTIMASERIE,MORACOMQUEM,APOSENTADO,SITUACAOFINANCEIRA," +
                        $"MEDIASALARIAL,PROFISSAO,MORADIA,ADMFINANCA,ADMFINANCATERCEIRO,TIPOTRANSPORTE,DIFICULDADELOCOMOVE,SEMDIFICULDADELOCOMOVE," +
                        $"BAIXAVISAO,BAIXAAUDICAO,AUXILIOMACHA,CEGO,SURDO,FUMA,BEBE,HIPERTENSO,CARDIACO,DIABETICO,ASMA,CANCERFAMILIA,COLESTEROLELEVADO," +
                        $"EPLETICO,DEPRESSAO,ALERGICO,ARTOSE,OSTEOPOROSE,RENAIS,ALZHEIMER,PARKINSON,USAMEDICAMENTO,QUALMEDICAMENTO,OUTRADOENCA,ATIVIDADEFISICA," +
                        $"QUALATIVIDADE,AUTONOMIA,SITUACAO,UFEMISSOR)" +
                        $"VALUES(" +
                        $"'" + inclusao + "','" + data + "','" + atualizacao + "','" + dataCriacao + "','" + nome + "','" + dataNasc + "','" + sexo + "','" + nis + "'," +
                        $"'" + cidade + "','" + uf + "','" + rg + "','" + cpf + "','" + emissor + "','" + telefone + "','" + telefone + "','" + cep + "','" + contatoEmergencia + "','" + foneEmergencia + "','" + etnia + "'," +
                        $"'" + participaGrupo + "','" + qualGrupo + "','" + estadoCivil + "','" + religiao + "','" + filhos + "','" + qtsFilhos + "','" + netos + "','" + qtsNetos + "','" + indigenas + "','" + reservaIndigenas + "'," +
                        $"'" + quilombola + "','" + comunidadequilombola + "','" + estrangeiro + "','" + qualPais + "','" + escolaridade + "','" + ultimaSerie + "','" + moraComQuem + "','" + aposentado + "','" + situacao + "'," +
                        $"'" + mediaSalarial + "','" + profissao + "','" + moradia + "','" + admFinancia + "','" + admFinanciaTerceiro + "','" + tipoTransporte + "','" + dificuldadeLocomocao + "','" + semDificuldadeLocomocao + "'," +
                        $"'" + baixaVisao + "','" + baixaVisao + "','" + auxiliomacha + "','" + cego + "','" + surdo + "','" + fuma + "','" + bebe + "','" + hipertenso + "','" + cardiaco + "','" + diabetico + "','" + asma + "','" + cancerFamilia + "','" + colesterolElevado + "'," +
                        $"'" + epletico + "','" + depressao + "','" + alergico + "','" + artose + "','" + osteoporose + "','" + renais + "','" + alzheimer + "','" + parkinson + "','" + usaMedicamento + "','" + qualMedicamento + "','" + outraDoenca + "','" + atividadeFisica + "'," +
                        $"'" + qualAtividadeFisica + "','" + autonomia + "','" + situacao + "','" + ufEmissor + "')";



                    FbCommand comando = new FbCommand(sql, con);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ficha salva com Sucesso!");
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
        public static void DeleteFicha(string codigo)
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    con.Open();
                    var sql = $"DELETE FROM FICHA WHERE ID = '{codigo}'";
                    FbCommand comando = new FbCommand(sql, con);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Ficha deletada com sucesso!");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao Deletar " + e.Message);
                }
                finally
                {
                    con.Close();
                }

            }
        }
        public static void GetFicha(DataGridView tabela)
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    con.Open();
                    var sql = "SELECT ID as CODIGO, nome as NOME, TELEFONE, SEXO, ENDERECO, CIDADE as NATURALIDADE from FICHA";
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

    }
}
