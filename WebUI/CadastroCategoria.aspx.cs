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
    public partial class CadastroCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //O código abaixo se aplica somente a WEB.
            if (!Page.IsPostBack)
            {
                CarregarCategorias();
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            //objCategoria.cdCategoria = Convert.ToInt32(txtCodigo.Text);
            objCategoria.DsCategoria = txtCategoria.Text;

            CategoriaDAL catDAL = new CategoriaDAL();
            catDAL.InserirCategoria(objCategoria);

            lblMensagem.Text = "Categoria inserida com sucesso.";
        }
        private void CarregarCategorias()
        {
            CategoriaDAL catDAL = new CategoriaDAL();
            grvCategorias.DataSource = catDAL.SelecionarTodasCategorias();
            grvCategorias.DataBind();
        }
    }
}