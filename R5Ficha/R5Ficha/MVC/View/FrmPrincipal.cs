using R5Ficha.MVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R5Ficha.MVC.View
{
    public partial class FrmPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            ModelUsuario.GetUsuario(tbUsuario);
            txtNome.Focus();
            tbUsuario.Columns[0].Width = 200;
            tbUsuario.Columns[1].Width = 617;
            tbUsuario.Columns[2].Visible = false;
            
        }
        string codigo;
        public void LimpaCampo()
        {
            txtConfSenha.Text = null;
            txtSenha.Text = null;
            txtNome.Text = null;
            codigo = null;
            btNovo.Enabled = true;
            btSalvar.Enabled = true;
        }        
        private void btSalvar_Click(object sender, EventArgs e)
        {
            if ((txtSenha.Text == txtConfSenha.Text) && (txtSenha.Text !="") && (txtConfSenha.Text!="") && (txtNome.Text != ""))
            {
                ModelUsuario.InserirUsuario(txtNome.Text,txtSenha.Text);
                LimpaCampo();
                ModelUsuario.GetUsuario(tbUsuario);
            }
            else
            {
                MessageBox.Show("Senhas diferentes");
            }    
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }
        private void tbUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            codigo  = tbUsuario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tbUsuario.CurrentRow.Cells[1].Value.ToString();
            txtSenha.Text = tbUsuario.CurrentRow.Cells[2].Value.ToString();
            txtConfSenha.Text = tbUsuario.CurrentRow.Cells[2].Value.ToString();
            btNovo.Enabled = false;
            btSalvar.Enabled = false;
        }
        private void btDeletar_Click(object sender, EventArgs e)
        {
            if(codigo != "" && codigo!= null)
            {
                ModelUsuario.DeleteUsuario(codigo);
                ModelUsuario.GetUsuario(tbUsuario);
                LimpaCampo();
            }
            else
            {
                MessageBox.Show("Necessário selecionar um usuário para deletar!");
            }
            
        }
        private void btNovo_Click(object sender, EventArgs e)
        {
            LimpaCampo();
            txtNome.Focus();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            ModelUsuario.UpdateUsuario(txtNome.Text,txtSenha.Text,codigo);
            ModelUsuario.GetUsuario(tbUsuario);
            LimpaCampo();
        }
    }
}
