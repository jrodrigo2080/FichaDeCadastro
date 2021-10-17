using FirebirdSql.Data.FirebirdClient;
using R5Ficha.MVC.Model;
using R5Ficha.MVC.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R5Ficha
{
    public partial class FrmLogin : MaterialSkin.Controls.MaterialForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            MVC.Util.itensUtil.configuraCores(this);
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
            {
                try
                {
                    con.Open();
                    var sql = $"select nome as NOME, senha AS SENHA from USUARIO where nome = '{txtUser.Text}' and senha = '{txtPas.Text}'";
                    FbCommand comando = new FbCommand(sql, con);
                    FbDataAdapter da = new FbDataAdapter(comando);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        Hide();
                        new MVC.View.FrmPrincipal().Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado! ");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Erro ao Fazer Login " + ex.Message); }
                finally { con.Close(); }
            }         
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new MVC.View.FrmConexao().ShowDialog();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.ProcessTabKey(true);
                e.Handled = true;
            }
        }
        private void txtPas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                using (FbConnection con = ModelConexao.GetInstancia().GetConexao())
                {
                    try
                    {
                        con.Open();
                        var sql = $"select nome as NOME, senha AS SENHA from USUARIO where nome = '{txtUser.Text}' and senha = '{txtPas.Text}'";
                        FbCommand comando = new FbCommand(sql, con);
                        FbDataAdapter da = new FbDataAdapter(comando);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            Hide();
                            new MVC.View.FrmPrincipal().Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado! ");
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Erro ao Fazer Login " + ex.Message);}
                    finally { con.Close(); }
                }
            }
        }
    }
}
