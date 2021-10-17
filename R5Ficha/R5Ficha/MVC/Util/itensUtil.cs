using FirebirdSql.Data.FirebirdClient;
using MaterialSkin;
using R5Ficha.MVC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R5Ficha.MVC.Util
{
    public class itensUtil
    {

        public static void configuraCores(MaterialSkin.Controls.MaterialForm form)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue300, 
                Primary.Blue300, 
                Primary.Blue200,
                Accent.LightBlue400, 
                TextShade.WHITE);
        }
        public static void preencheComboBoxBotoes(ComboBox comboBox)
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    con.Open();
                    var sql = "select id_oficina as CODIGO, nome as NOME from OFICINA order by nome";
                    //FbCommand comando = new FbCommand(sql, con);
                    FbDataAdapter da = new FbDataAdapter(sql, con);
                    DataTable dtResultado = new DataTable();
                    dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
                    comboBox.DataSource = null;
                    da.Fill(dtResultado);
                    comboBox.DataSource = dtResultado;
                    comboBox.ValueMember = "codigo";
                    comboBox.DisplayMember = "nome";
                    comboBox.SelectedItem = "";
                    comboBox.Refresh();
                }
                catch (Exception e) { MessageBox.Show("Erro ao Listar " + e.Message); }
                finally { con.Close(); }

            }
        }
        public static void eventoEnter(object sender, KeyPressEventArgs e, TextBox campoSeguinte)
        {
            if(e.KeyChar == 13)
            {
                campoSeguinte.Focus();
            }
        }
        public static void buscarGenerico(DataGridView tabela, string sql)
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    con.Open();
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
