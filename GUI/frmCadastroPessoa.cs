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
    public partial class frmCadastroPessoa : Form
    {
        public frmCadastroPessoa()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            Pessoa objPessoa = new Pessoa();
            objPessoa.Nome = txtNome.Text;
            objPessoa.DtNasc = Convert.ToDateTime(txtNasc.Text);
            objPessoa.Email = txtEmail.Text;
            //if (rbtnMasc.Checked)
            //{
            //    objPessoa.Sexo = "M";
            //}
            //else
            //{
            //    objPessoa.Sexo = "F";
            //}
            //Código abaixo faz o IF em 1 linha onde o ? faz a pergunta e o senão é o :
            objPessoa.Sexo = (rbtnMasc.Checked ? "M" : "F");
            objPessoa.EstadoCivil = cbxEstCiv.Text;
            objPessoa.RecebeEmail = ckbRecEmail.Checked;
            objPessoa.RecebeSMS = ckbRecSMS.Checked;

            PessoaDAL pDAL = new PessoaDAL();
            pDAL.InserirPessoa(objPessoa);

            MessageBox.Show("Adicionado com sucesso");
            LimparCampos();
            btnCancelar.Enabled = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisar.Text;
            PessoaDAL pDAL = new PessoaDAL();
            dgvPesquisar.DataSource = pDAL.BuscarPessoas(nome);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                int cdPessoa = Convert.ToInt32(txtCodigo.Text);

                PessoaDAL pDAL = new PessoaDAL();

                Pessoa objPessoa = pDAL.SelecionarPessoaPeloCodigo(cdPessoa);

                if (objPessoa != null)
                {
                    txtNome.Text = objPessoa.Nome;
                    txtNasc.Text = objPessoa.DtNasc.ToString();
                    txtEmail.Text = objPessoa.Email;
                    rbtnMasc.Checked = objPessoa.Sexo == "M";
                    rbtnFem.Checked = objPessoa.Sexo == "F";
                    cbxEstCiv.Text = objPessoa.EstadoCivil;
                    ckbRecEmail.Checked = objPessoa.RecebeEmail;
                    ckbRecSMS.Checked = objPessoa.RecebeSMS;
                }
                else
                {
                    MessageBox.Show("Nenhuma pessoa localizada");
                }  
            }
            else
            {
                MessageBox.Show("Digite algum código");
            }
            btnCancelar.Enabled = true;
            btnAtualizar.Enabled = true;
            btnExcluir.Enabled = true;

        }
        private void frmCadastroPessoa_Load(object sender, EventArgs e)
        {
            //Código abaixo faz com que o item selecionado seja o item 0 (Primeiro)
            cbxEstCiv.SelectedIndex = 0;
            CarregarPessoas();
        }
        private void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtNasc.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbxEstCiv.SelectedIndex = 0;
            ckbRecEmail.Checked = false;
            ckbRecSMS.Checked = false;

            CarregarPessoas();

        }

        private void CarregarPessoas()
        {
            PessoaDAL pDAL = new PessoaDAL();
            dgvPesquisar.DataSource = pDAL.SelecionarTodasPessoas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa();
            objPessoa.CdPessoa = Convert.ToInt32(txtCodigo.Text);
            objPessoa.Nome = txtNome.Text;
            objPessoa.DtNasc = Convert.ToDateTime(txtNasc.Text);
            objPessoa.Email = txtEmail.Text;
            objPessoa.Sexo = (rbtnMasc.Checked ? "M" : "F");
            objPessoa.EstadoCivil = cbxEstCiv.Text;
            objPessoa.RecebeEmail = ckbRecEmail.Checked;
            objPessoa.RecebeSMS = ckbRecSMS.Checked;

            PessoaDAL pDAL = new PessoaDAL();
            pDAL.Atualizar(objPessoa);

            MessageBox.Show("Pessoa atualizada com sucesso.");
            LimparCampos();
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codPessoa = Convert.ToInt32(txtCodigo.Text);
            PessoaDAL pDAL = new PessoaDAL();
            pDAL.Excluir(codPessoa);

            MessageBox.Show("Pessoa excluida com sucesso.");
            LimparCampos();
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }
    }
}
