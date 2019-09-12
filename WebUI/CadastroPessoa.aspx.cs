using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace WebUI
{
    public partial class CadastroPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) // Quando não é um postback (Exclamação = Negação)
            {
                MostrarTodasPessoas(); //Se deixar esse método fora do IF o carro nem vai abrir, vai ficar num looping
            }
        }

        protected void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtDataNasc.Text = string.Empty;
            txtEmail.Text = string.Empty;
            rbtnMasc.Checked = false;
            rbtnFem.Checked = false;
            cboxRecebeEmail.Checked = false;
            cboxRecebeSMS.Checked = false;

            MostrarTodasPessoas();
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int CdPessoa = Convert.ToInt32(txtCodigo.Text);

            PessoaDAL pDAL = new PessoaDAL();
            Pessoa ObjPessoa = pDAL.SelecionarPessoaPeloCodigo(CdPessoa);

            if (ObjPessoa != null)
            {
                txtNome.Text = ObjPessoa.Nome;
                txtDataNasc.Text = ObjPessoa.DtNasc.ToString();
                txtEmail.Text = ObjPessoa.Email;
                rbtnMasc.Checked = ObjPessoa.Sexo == "M";
                rbtnFem.Checked = ObjPessoa.Sexo == "F";
                ddlEstadoCivil.Text = ObjPessoa.EstadoCivil;
                cboxRecebeEmail.Checked = ObjPessoa.RecebeEmail;
                cboxRecebeSMS.Checked = ObjPessoa.RecebeSMS;

                lblMensagem.Text = string.Empty;
                btnAtualizar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                lblMensagem.Text = "A Pessoa não foi encontrada.";
                LimparCampos();
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();
            objPessoa.Nome = txtNome.Text;
            objPessoa.DtNasc = Convert.ToDateTime(txtDataNasc.Text);
            objPessoa.Email = txtEmail.Text;
            objPessoa.Sexo = (rbtnMasc.Checked ? "M" : "F");
            objPessoa.EstadoCivil = ddlEstadoCivil.Text;
            objPessoa.RecebeEmail = cboxRecebeEmail.Checked;
            objPessoa.RecebeSMS = cboxRecebeSMS.Checked;

            PessoaDAL pDAL = new PessoaDAL();
            pDAL.InserirPessoa(objPessoa);

            lblMensagem.Text = "Pessoa inserida com sucesso.";
            LimparCampos();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnCancelar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int cdPessoa = Convert.ToInt32(txtCodigo.Text);

            PessoaDAL pDAL = new PessoaDAL();

            pDAL.Excluir(cdPessoa);

            lblMensagem.Text = "Pessoa excluída com sucesso.";
            LimparCampos();
            btnExcluir.Enabled = false;
            btnAtualizar.Enabled = false;
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();
            objPessoa.CdPessoa = Convert.ToInt32(txtCodigo.Text);
            objPessoa.Nome = txtNome.Text;
            objPessoa.DtNasc = Convert.ToDateTime(txtDataNasc.Text);
            objPessoa.Email = txtEmail.Text;
            objPessoa.Sexo = (rbtnMasc.Checked ? "M" : "F");
            objPessoa.EstadoCivil = ddlEstadoCivil.Text;
            objPessoa.RecebeEmail = cboxRecebeEmail.Checked;
            objPessoa.RecebeSMS = cboxRecebeSMS.Checked;

            PessoaDAL pDAL = new PessoaDAL();
            pDAL.Atualizar(objPessoa);

            lblMensagem.Text = "Pessoa atualizada com sucesso";
            LimparCampos();
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void MostrarTodasPessoas()
        {
            PessoaDAL pDAL = new PessoaDAL();
            grvPessoas.DataSource = pDAL.SelecionarTodasPessoas();
            grvPessoas.DataBind();
        }
    }
}