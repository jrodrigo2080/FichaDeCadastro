using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R5Ficha.Relatorio
{
    public partial class FrmRelatorioFicha : Form
    {
        public FrmRelatorioFicha()
        {
            InitializeComponent();
        }        

        private void FrmRelatorioFicha_Load(object sender, EventArgs e)
        {            
            this.reportViewer1.RefreshReport();
        }

        public void GeraPDF(string inclusao,string data,string atualizacao,string dataInclusao,string nome,string oficina,string dataNasc,string sexo,string nis,
            string naturalidade,string uf,string rg,string cpf, string emissor, string ufEmissor, string telefone,string cep, string endereco, string contatoEmergencia,
            string foneEmergencia,string etnia,string estadoCivil, string religiao,string participaGrupo,string qualGrupo, string temFilhos, string qtsFilhos,
            string temNetos,string qtsNetos,string indigena, string reserva, string quilombola, string comunidade, string estrangeiro, string pais)
        {
            inclusao = inclusao == "S" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            atualizacao = atualizacao == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            participaGrupo = participaGrupo == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            temFilhos = temFilhos == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            temNetos = temNetos == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            sexo = sexo == "M" ? "(X)M ( )F" : "( )M (X)F";            
            
            //---
            qualGrupo = qualGrupo != "" ? "Qual Grupo? " + qualGrupo : "";
            qtsFilhos = qtsFilhos != "" ? "Quantos? " + qtsFilhos : "";
            qtsNetos = qtsNetos != "" ? "Quantos? " + qtsNetos : "";
            reserva = reserva != "" ? "Reserva? " + reserva : "";
            comunidade = comunidade != "" ? "Comunidade? "+comunidade :"";
            estrangeiro = estrangeiro != "" ? "Pais? " + pais : "";
            //---
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("inclusao", inclusao));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("data", data));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("atualizacao", atualizacao));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataInclusao", dataInclusao));            
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nome", nome));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("oficina", oficina));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataNascimento", dataNasc));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("sexo", sexo));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nis", nis));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cidade", naturalidade));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("uf", uf));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("rg", rg));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cpf", cpf));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("emissor", emissor));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ufEmissor", ufEmissor));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("telefone", telefone));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cep", cep));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("endereco", endereco));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("contatoEmergencia", contatoEmergencia));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("foneEmergencia", foneEmergencia));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("etnia", etnia));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("estadoCivil", estadoCivil));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("religiao", religiao));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("participaGrupo", participaGrupo));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("qualGrupo", qualGrupo));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("filhos", temFilhos));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("qtsFilhos", qtsFilhos));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("netos", temNetos));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("qtsNetos", qtsNetos));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("indigena", indigena));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("reserva", reserva));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("quilombola", quilombola));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("comunidade", comunidade));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("estrangeiro", estrangeiro));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("pais", pais));
            
            //---
            this.reportViewer1.RefreshReport();
        }

    }
}
