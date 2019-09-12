using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Models;

namespace GUI
{
    public partial class frmCadastroCategoria : Form
    {
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.DsCategoria = txtCategoria.Text;

            CategoriaDAL catDAL = new CategoriaDAL();
            catDAL.InserirCategoria(objCategoria);

            MessageBox.Show("Categoria adicionada com sucesso.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                int cdCategoria = Convert.ToInt32(txtCodigo.Text);

                CategoriaDAL cDAL = new CategoriaDAL();
                Categoria objCategoria = cDAL.BuscarCategoriaPeloCodigo(cdCategoria);

                if (objCategoria != null) txtCategoria.Text = objCategoria.DsCategoria.ToString();
                else MessageBox.Show("Nenhuma categoria localizada");
            }
            else MessageBox.Show("Digite um código");
         }


    }
}
