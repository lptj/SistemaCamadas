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
    public partial class TesteFileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CarregarFotos();
            }
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (fupImagem.HasFile)
            {
                Foto objFoto = new Foto();
                objFoto.DsTitulo = txtTitulo.Text;
                objFoto.NmArquivo = fupImagem.FileName;

                FotoDAL fDAL = new FotoDAL();
                fDAL.InserirFoto(objFoto);

                //string caminho = "C:\\Imagens\\Teste.jpg"; //Se der somente 1 barra ele vai achar que o próx. caracter seja um comando. Com o @ antes afirma que o código a seguir não terá nenhum comando. Ex.: @"C:\Imagens\Teste.jpg"
                //string caminho = @"C:\Imagens\" + fupImagem.FileName;
                string caminho = Server.MapPath(@"Imagens\") + fupImagem.FileName; //Usa o comando Server.MapPath para saber onde está a Pasta Raiz pois sempre há alterações de pc para pc.
                fupImagem.SaveAs(caminho); 
                lblMensagem.Text = "Arquivo salvo com sucesso.";
            }
            else
            {
                lblMensagem.Text = "Não existe arquivo selecionado.";
            }
        }
        private void CarregarFotos()
        {
            FotoDAL fDAL = new FotoDAL();
            grvFotos.DataSource = fDAL.ListarFotos();
            grvFotos.DataBind();
        }

        protected void grvFotos_RowCommand(object sender, GridViewCommandEventArgs e) //Na variável e esta o command name.
        {
            switch(e.CommandName)
            {
                case "Editar":
                    int cdFoto = Convert.ToInt32(e.CommandArgument); //Dentro do CommandArgumento vem escrito o código da foto de cada uma das linhas

                    FotoDAL fDAL = new FotoDAL();
                    Foto objFoto = fDAL.SelecionarFotoPeloCodigo(cdFoto);

                    txtCódigo.Text = objFoto.CdFoto.ToString();
                    txtTitulo.Text = objFoto.DsTitulo.ToString();
                    imgFoto.ImageUrl = "Imagens/" + objFoto.NmArquivo;
                    //Fazer o select no banco e trazer no objeto
                    break;
            }
        }
    }
}