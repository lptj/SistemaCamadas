using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCarro tela = new frmCadastroCarro();
            tela.MdiParent = this;
            tela.Show();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPessoa tela = new frmCadastroPessoa();
            tela.MdiParent = this;
            tela.Show();
        }
        private void exceçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTesteExcecao tela = new frmTesteExcecao();
            tela.MdiParent = this;
            tela.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria tela = new frmCadastroCategoria();
            tela.MdiParent = this;
            tela.Show();
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroJogo tela = new frmCadastroJogo();
            tela.MdiParent = this;
            tela.Show();
        }
    }
}
