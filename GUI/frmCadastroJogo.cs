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
    public partial class frmCadastroJogo : Form
    {
        public frmCadastroJogo()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Jogo objJogo = new Jogo();
            objJogo.NmJogo = txtNmJogo.Text;

            JogoDAL jDAL = new JogoDAL();

            if (!string.IsNullOrWhiteSpace(objJogo.NmJogo))
            {
                try
                {
                    jDAL.InserirJogo(objJogo);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Não é permitido nome em branco");
            }
        }

        private void CarregarJogos()
        {
            JogoDAL jDAL = new JogoDAL();

            try
            {
                dgvJogos.DataSource = jDAL.BuscarTodosJogos();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void frmCadastroJogo_Load(object sender, EventArgs e)
        {
            CarregarJogos();
        }
    }
}
