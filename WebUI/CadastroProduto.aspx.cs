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
    public partial class CadastroProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarCategorias();
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Produto objProduto = new Produto();
            objProduto.DsProduto = txtDescricao.Text;
            objProduto.VlUnitario = Convert.ToDecimal(txtVlUnitario.Text);
            objProduto.CdCategoria = Convert.ToInt32(ddlCategorias.SelectedValue); //Propriedade Especifica que pega o valor selecionado

            ProdutoDAL pDAL = new ProdutoDAL();
            pDAL.InserirProduto(objProduto);
        }
        private void CarregarCategorias()
        {
            //O código abaixo pega dados do dropdown list e pega do banco de dados
            CategoriaDAL cDAL = new CategoriaDAL();

            ddlCategorias.AppendDataBoundItems = true; //Pode colocar itens na mão e quando fizer o datasource não vai sobrepor os que foram feito na mão
            ddlCategorias.Items.Add(new ListItem("Selecione uma categoria", "")); // Esse código define a pré opção do drop down list pedindo ao usuário para digitar uma categoria.
            ddlCategorias.DataTextField = "DsCategoria"; //O campo que vai aparecer para o usuário
            ddlCategorias.DataValueField = "CdCategoria"; //Campo que precisa para guardar algo na tabela de produtos = Código
            ddlCategorias.DataSource = cDAL.SelecionarTodasCategorias();
            ddlCategorias.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int CdProduto = Convert.ToInt32(txtCodigo.Text);

            ProdutoDAL pDAL = new ProdutoDAL();
            Produto objProduto = pDAL.BuscarProdutoPeloCodigo(CdProduto);

            if (objProduto != null)
            {
                txtDescricao.Text = objProduto.DsProduto;
                txtVlUnitario.Text = objProduto.VlUnitario.ToString();
                ddlCategorias.SelectedValue = objProduto.CdCategoria.ToString();
            }
            else
            {
                lblMensagem.Text = "O produto não foi encontrado.";
            }
        }

        public void Limpar()
        {
            txtCodigo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtVlUnitario.Text = string.Empty;
            ddlCategorias.SelectedIndex = 0; //Este código serve para poder limpar o drop down list selecionado
            //ou
            //ddlCategorias.SelectedValue = ""; //Esse só funciona com o item adicionado pela programação
            //Programar o botão Cancelar para limpar o conteúdo.
        }
    }
}