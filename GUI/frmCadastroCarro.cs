using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models;
using DAL;

namespace GUI
{
    public partial class frmCadastroCarro : Form
    {
        public frmCadastroCarro()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
                Carro objCarro = new Carro();
                objCarro.DsMarca = txtMarca.Text;
                objCarro.DsModelo = txtModelo.Text;
                objCarro.DsCor = txtCor.Text;
                objCarro.Ano = Convert.ToInt32(txtAno.Text);

                //Enviar para a camada de banco de dados conforme código abaixo.
                CarroDAL cDAL = new CarroDAL();
                cDAL.InserirCarro(objCarro);

                MessageBox.Show("Adicionado com sucesso");

                LimparCampos();
         }
        

        private void btnBuscar_Click(object sender, EventArgs e)
        {
                if (txtCodigo.Text != "")
                {
                int cdCarro = Convert.ToInt32(txtCodigo.Text);
                
                CarroDAL cDAL = new CarroDAL();

                Carro objCarro = cDAL.SelecionarCarroPeloCodigo(cdCarro);

                if (objCarro != null)
                {
                    txtMarca.Text = objCarro.DsMarca;
                    txtModelo.Text = objCarro.DsModelo;
                    txtCor.Text = objCarro.DsCor;
                    txtAno.Text = objCarro.Ano.ToString();

                    txtCodigo.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnAdicionar.Enabled = false;
                    btnAtualizar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Carro não encontrado.");
                }
            }
            else
                MessageBox.Show("Digite algum valor");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            //Limpa os dados nos textbox
            txtCodigo.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtCor.Text = string.Empty;
            txtAno.Text = string.Empty;

            txtCodigo.Enabled = true;
            btnBuscar.Enabled = true;
            btnAdicionar.Enabled = true;
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
            CarregarCarros();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Etapa onde será atualizado o formulário de campo em campo conforme abaixo.
            //É necessário sempre instanciar o objeto para poder puxar as informações
            Carro objCarro = new Carro();
            objCarro.CdCarro = Convert.ToInt32(txtCodigo.Text);
            objCarro.DsMarca = txtMarca.Text;
            objCarro.DsModelo = txtModelo.Text;
            objCarro.DsCor = txtCor.Text;
            objCarro.Ano = Convert.ToInt32(txtAno.Text);

            //Sempre necessário instanciar o objeto CarroDAL para poder manusear e puxar o método Atualizar contido nele
            CarroDAL cDAL = new CarroDAL();
            cDAL.Atualizar(objCarro);

            MessageBox.Show("Carro atualizado com sucesso.");

            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codcarro = Convert.ToInt32(txtCodigo.Text);

            CarroDAL cDAL = new CarroDAL();
            cDAL.Excluir(codcarro);

            LimparCampos();

            MessageBox.Show("Carro excluido com sucesso.");

            btnExcluir.Enabled = false;
        }

        //Esse método vai puxar os dados da camada carros(Da lista criada) para dentro da Grid View
        private void CarregarCarros()
        {
            CarroDAL cDAL = new CarroDAL();
            //Código abaixo faz sozinho o código para listar os carros
            dgvCarros.DataSource = cDAL.SelecionarTodosCarros();
        }

        private void frmCadastroCarro_Load(object sender, EventArgs e)
        {
            //Para criar o load form é só clicar 2 vezes em alguma parte da tela no design
            CarregarCarros();
        }
    }
}
