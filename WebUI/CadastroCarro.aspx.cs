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
    public partial class CadastroCarro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) // Quando não é um postback (Exclamação = Negação)
            {
                CarregarCarros(); //Se deixar esse método fora do IF o carro nem vai abrir, vai ficar num looping
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Carro objCarro = new Carro();
            objCarro.DsMarca = txtMarca.Text;
            objCarro.DsModelo = txtModelo.Text;
            objCarro.DsCor = txtCor.Text;
            objCarro.Ano = Convert.ToInt32(txtAno.Text);

            CarroDAL cDAL = new CarroDAL();
            cDAL.InserirCarro(objCarro);

            lblMensagem.Text = "Carro adicionado com sucesso";
            Limpar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int cdCarro = Convert.ToInt32(txtCodigo.Text);

            CarroDAL cDAL = new CarroDAL();

            Carro objCarro = cDAL.SelecionarCarroPeloCodigo(cdCarro);
            if(objCarro != null)
            {
                txtMarca.Text = objCarro.DsMarca;
                txtModelo.Text = objCarro.DsModelo;
                txtCor.Text = objCarro.DsCor;
                txtAno.Text = objCarro.Ano.ToString();

                lblMensagem.Text = string.Empty;
                btnCancelar.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                Limpar();
                lblMensagem.Text = "O carro não foi encontrado";
                btnCancelar.Enabled = false;
            }
        }

        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            Carro objCarro = new Carro();
            objCarro.CdCarro = Convert.ToInt32(txtCodigo.Text);
            objCarro.DsMarca = txtMarca.Text;
            objCarro.DsModelo = txtModelo.Text;
            objCarro.DsCor = txtCor.Text;
            objCarro.Ano = Convert.ToInt32(txtAno.Text);

            CarroDAL cDAL = new CarroDAL();
            cDAL.Atualizar(objCarro);

            lblMensagem.Text = "Carro atualizado com sucesso";
            Limpar();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            int cdCarro = Convert.ToInt32(txtCodigo.Text);

            CarroDAL cDAL = new CarroDAL();
            cDAL.Excluir(cdCarro);

            lblMensagem.Text = "Carro excluído com sucesso";
            btnExcluir.Enabled = false;
            Limpar();
        }
        protected void Limpar()
        {
            txtCodigo.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtCor.Text = string.Empty;
            txtAno.Text = string.Empty;

            CarregarCarros();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
        }
        private void CarregarCarros()
        {
            CarroDAL cDAL = new CarroDAL();
            grvCarros.DataSource = cDAL.SelecionarTodosCarros();
            // O código abaixo faz com que a grid seja preenchida com os dados e exibido na tela
            grvCarros.DataBind();
        }
    }
}