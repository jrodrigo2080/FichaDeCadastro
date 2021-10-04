using R5Ficha.MVC.Model;
using R5Ficha.Relatorio;
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
            ModelFicha.GetFicha(tbFicha);
            ModelOficina.GetOficina(dbOficina);
            txtNome.Focus();
            organizaTbUsuario();
            organizaTbFicha();
            organizaTbOficina();
            Util.itensUtil.preencheComboBoxBotoes(cbOficina);
        }
        string codigo ="";
        string codigoOficina="";
        public void organizaTbUsuario()
        {
            tbUsuario.Columns[0].Width = 200;
            tbUsuario.Columns[1].Width = 617;
            tbUsuario.Columns[2].Visible = false;
        }
        public void organizaTbFicha()
        {
            tbFicha.Columns[0].Width = 100;
            tbFicha.Columns[1].Width = 300;
            tbFicha.Columns[2].Width = 150;
            tbFicha.Columns[3].Width = 100;
            tbFicha.Columns[4].Width = 250;
        }
        public void organizaTbOficina()
        {
            dbOficina.Columns[0].Width = 100;
            dbOficina.Columns[1].Width = 250;
        }
        public void LimpaCampo()
        {
            txtConfSenha.Text = null;
            txtSenha.Text = null;
            txtNome.Text = null;
            codigo = null;
            btNovo.Enabled = true;
            btSalvar.Enabled = true;
        } 
        //------ Função dos Botoes
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
        private void btSalvarFicha_Click(object sender, EventArgs e)
        {
            //Esse evento trata os campos
            var inclusao = txtInclusao.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            var atualizacao = txtAtualizacao.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            var participaGrupo = txtParticipaGrupo.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            var temFilhos = txtTemFIlhos.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            var temNetos = txtNetos.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            var indigena = txtIndigenas.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            var quilombola = txtQuilombola.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            var estrangeiro = txtEstrangeiro.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            var atividade = txtAtividadeFisic.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            var medicamento = txtMedicamento.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            var fuma = txtFuma.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            var aposentado = txtAposentado.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            var admFinanca = txtAdmFinanca.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            var financaTerceiro = txtAdmFinancaTerceiro.SelectedIndex.ToString().Equals("1") ? "S" : "N";
            
            var hipertenso = txtHipertenso.Checked == true ? "S" : "N";
            var cardiaco = txtCardiaco.Checked == true ? "S" : "N";
            var diabetico = txtDiabetico.Checked == true ? "S" : "N";
            var asma = txtAsma.Checked == true ? "S" : "N";
            var cancer = txtHistoricoCancer.Checked == true ? "S" : "N";
            var colesterol = txtColesterol.Checked == true ? "S" : "N";
            var depressao = txtDeprecao.Checked == true ? "S" : "N";
            var alergico = txtAlergico.Checked == true ? "S" : "N";
            var artrose = txtArtose.Checked == true ? "S" : "N";
            var osteoporose = txtOsteoporose.Checked == true ? "S" : "N";
            var renais = txtRenais.Checked == true ? "S" : "N";
            var alzheimer = txtAlzheimer.Checked == true ? "S" : "N";
            var parkinson = txtParkinson.Checked == true ? "S" : "N";
            var epletico = txtEpletico.Checked == true ? "S" : "N";
            var baixavisao = txtBaixaVisao.Checked == true ? "S" : "N";
            var baixaaudicao = txtBaixaAudicao.Checked == true ? "S" : "N";
            var cego = txtCego.Checked == true ? "S" : "N";
            var surdo = txtSurdo.Checked == true ? "S" : "N";
            var locomoveBem = txtLocomoveSemDifi.Checked == true ? "S" : "N";
            var malLocomove = txtLocomoveComDific.Checked == true ? "S" : "N";
            var usomarcha = txtUsoMArcha.Checked == true ? "S" : "N";

            FrmRelatorioFicha rel = new FrmRelatorioFicha();
            rel.GeraPDF(inclusao,data: txtData.Text, atualizacao, txtDataInclusao.Text,txtNomeCadastro.Text,cbOficina.Text,
                txtDataNasc.Text,txtSexo.Text,txtNis.Text,txtNaturalidade.Text,txtUfNaturalidade.Text,txtRg.Text,txtCpf.Text,
                txtOrgaoEmisor.Text,txtUfEmissor.Text,txtTelefone.Text,txtCep.Text,txtEndereco.Text,txtContatoEmergencia.Text,
                txtFoneEmergencia.Text,txtEtnia.Text,txtEstadoCivil.Text,txtReligiao.Text,txtParticipaGrupo.Text,txtQualGrupo.Text,
                txtTemFIlhos.Text,txtQtsFilhos.Text,txtNetos.Text,txtQtsNetos.Text,txtIndigenas.Text,txtReservaIndigena.Text,
                txtQuilombola.Text,txtComunidade.Text,txtEstrangeiro.Text,txtPais.Text);
            rel.ShowDialog();

            //Esse evento faz a inserção no banco
            ModelFicha.InserirFicha(cbOficina.Text,inclusao,txtData.Text, atualizacao, txtDataInclusao.Text, txtNomeCadastro.Text,
                txtDataNasc.Text, txtSexo.Text, txtNis.Text,txtNaturalidade.Text,txtUfNaturalidade.Text,
                txtRg.Text,txtCpf.Text,txtOrgaoEmisor.Text,txtTelefone.Text,
                txtEndereco.Text,txtCep.Text,txtContatoEmergencia.Text,txtFoneEmergencia.Text,
                txtEtnia.Text,participaGrupo,txtQualGrupo.Text,txtEstadoCivil.Text,
                txtReligiao.Text,temFilhos,txtQtsFilhos.Text,temNetos,txtQtsNetos.Text,indigena,
                txtReservaIndigena.Text,quilombola,txtComunidade.Text,
                estrangeiro,txtPais.Text,txtEscolaridade.Text,txtUltimaSerie.Text,txtMoraComQuem.Text,
                aposentado,txtSituacaoFinanceira.Text,txtMEdiaSalarial.Text,txtProfissao.Text,txtMoradia.Text,
                admFinanca, financaTerceiro, txtTipoTransport.Text, malLocomove,
                locomoveBem,baixavisao,
                baixaaudicao,usomarcha,cego,surdo,fuma,txtBebe.Text,
                hipertenso,cardiaco,
                diabetico,asma,cancer,colesterol,epletico,
                depressao,alergico,artrose,
                osteoporose,renais,alzheimer,parkinson,medicamento,
                txtQualMEdicamento.Text, txtOutraDoenca.Text, atividade,txtQualAtividade.Text, txtAutonomia.Text, 
                txtSituacao.Text, txtUfEmissor.Text
                );
            
            ModelFicha.GetFicha(tbFicha);
        }
        private void btExportar_Click(object sender, EventArgs e)
        {
            var inclusao = "S";
            FrmRelatorioFicha rel = new FrmRelatorioFicha();
            //rel.GeraPDF(inclusao);
            rel.ShowDialog();
        }
        private void btSalvarOficina_Click(object sender, EventArgs e)
        {
            ModelOficina.InserirOficina(txtOficina.Text);
            ModelOficina.GetOficina(dbOficina);
        }
        private void dbOficina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoOficina = dbOficina.CurrentRow.Cells[0].Value.ToString();
            txtOficina.Text = dbOficina.CurrentRow.Cells[1].Value.ToString();
            btNovoOficina.Enabled = false;
            btSalvarOficina.Enabled = false;
        }
        private void btDeletarOficina_Click(object sender, EventArgs e)
        {
            ModelOficina.DeleteOficina(codigoOficina);
            ModelOficina.GetOficina(dbOficina);
            btNovoOficina.Enabled = true;
            btSalvarOficina.Enabled = true;
        }
        private void btEditarOficina_Click(object sender, EventArgs e)
        {
            ModelOficina.UpdateOficina(txtOficina.Text, codigoOficina);
            ModelOficina.GetOficina(dbOficina);
            btNovoOficina.Enabled = true;
            btSalvarOficina.Enabled = true;
        }
        private void dbOficina_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoOficina = dbOficina.CurrentRow.Cells[0].Value.ToString();
            txtOficina.Text = dbOficina.CurrentRow.Cells[1].Value.ToString();
            btNovoOficina.Enabled = false;
            btSalvarOficina.Enabled = false;
        }
    }
}
