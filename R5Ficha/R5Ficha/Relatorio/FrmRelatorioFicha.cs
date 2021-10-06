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
            string temNetos,string qtsNetos,string indigena, string reserva, string quilombola, string comunidade, string estrangeiro, string pais,
            string moraComQuem, string aposentado, string situacaoFinanceira, string mediaSalario, string profissao, string moradia, string admFinanca, string tipoTransporte, string financaTerceiro,
            string escolaridade, string fuma,string bebe, string situacao, string autonomia, string hipertenso, string cardiaco, string diabetico, string asma, string cancer,
            string colesterol, string epletico, string usaMedicamento, string qualMedicamento, string depressao, string alergico, string artrose, string osteoporose, string renais,
            string alzheimer, string parkinson, string outrasDoencas, string praticaAtividade, string qualAtividade)
        {
            inclusao = inclusao == "S" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            atualizacao = atualizacao == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            participaGrupo = participaGrupo == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            temFilhos = temFilhos == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            temNetos = temNetos == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            sexo = sexo == "M" ? "(X)M ( )F" : "( )M (X)F";
            indigena = indigena == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            quilombola = quilombola == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            estrangeiro = estrangeiro == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            aposentado = aposentado == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            admFinanca = admFinanca == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            financaTerceiro = financaTerceiro == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            fuma = fuma == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            hipertenso = hipertenso == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            cardiaco = cardiaco == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            diabetico = diabetico == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            asma = asma == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            cancer = cancer == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            colesterol = colesterol == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            epletico = epletico == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            usaMedicamento = usaMedicamento == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            praticaAtividade = praticaAtividade == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            depressao = depressao == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            alergico = alergico == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            artrose = artrose == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            osteoporose = osteoporose == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            renais = renais == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            alzheimer = alzheimer == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            parkinson = parkinson == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            estrangeiro = estrangeiro == "Sim" ? "(X)SIM ( )NÃO" : "( )SIM (X)NÃO";
            //---
            qualGrupo = qualGrupo != "" ? "Qual Grupo? " + qualGrupo : "";
            qtsFilhos = qtsFilhos != "" ? "Quantos? " + qtsFilhos : "";
            qtsNetos = qtsNetos != "" ? "Quantos? " + qtsNetos : "";
            reserva = reserva != "" ? "Reserva? " + reserva : "";
            comunidade = comunidade != "" ? "Comunidade? "+comunidade :"";
            nome = nome != "" ? nome : " ";
            oficina = oficina != "" ? oficina : " ";
            nis = nis != "" ? nis : " ";
            naturalidade = naturalidade != "" ? naturalidade : " ";
            rg = rg != "" ? rg : " ";
            cpf = cpf != "" ? cpf : " ";
            emissor = emissor != "" ? emissor : " ";
            telefone = telefone != "" ? telefone : " ";
            cep = cep != "" ? cep : " ";
            endereco = endereco != "" ? endereco : " ";
            contatoEmergencia = contatoEmergencia != "" ? contatoEmergencia : " ";
            foneEmergencia = foneEmergencia != "" ? foneEmergencia : " ";
            religiao = religiao != "" ? religiao : " ";
            profissao = profissao != "" ? profissao : " ";
            outrasDoencas = outrasDoencas != "" ? outrasDoencas : " ";
            qualMedicamento = qualMedicamento != "" ? qualMedicamento : " ";
            qualAtividade = qualAtividade != "" ? qualAtividade : " ";
            qualGrupo = qualGrupo != "" ? qualGrupo : " ";
            qtsFilhos = qtsFilhos != "" ? qtsFilhos : " ";
            qtsNetos = qtsNetos != "" ? qtsNetos : " ";
            reserva = reserva != "" ? reserva : " ";
            comunidade = comunidade != "" ? comunidade : " ";
            pais = pais != "" ? "Pais? " + pais : " ";
            moraComQuem = moraComQuem != "" ? moraComQuem : " ";
            
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
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("moraComQuem", moraComQuem));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("aposentado", aposentado));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("situacaoFinanceira", situacaoFinanceira));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("mediaSalario", mediaSalario));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("profissao", profissao));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("moradia", moradia));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("admFinanca", admFinanca));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("tipoTransporte", tipoTransporte));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fiancaTerceiro", financaTerceiro));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("escolaridade", escolaridade));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("fuma", fuma));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("bebe", bebe));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("situacao", situacao));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("autonomia", autonomia));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("hipertenso", hipertenso));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cardiaco", cardiaco));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("diabetico", diabetico));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("asma", asma));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cancer", cancer));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("colestorol", colesterol));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("epletico", epletico));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("usaMedicamento", usaMedicamento));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("qualMedicamento", qualMedicamento));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("praticaAtividade", praticaAtividade));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("qualAtividade", qualAtividade));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("depressao", depressao));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("alergico", alergico));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("artrose", artrose));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("osteopor", osteoporose));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("renais", renais));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("alzheimer", alzheimer));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("parkinson", parkinson));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("outraDoenca", outrasDoencas));
            
            //---
            this.reportViewer1.RefreshReport();
        }

    }
}
