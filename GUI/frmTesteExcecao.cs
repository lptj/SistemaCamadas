using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI
{
    public partial class frmTesteExcecao : Form
    {
        public frmTesteExcecao()
        {
            InitializeComponent();
        }

        private void exceçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTesteExcecao tela = new frmTesteExcecao();
            tela.MdiParent = this;
            tela.Show();
        }

        private void btnTeste1_Click(object sender, EventArgs e)
        {
            string palavra = "Batata";
            int numero;

            //numero = Convert.ToInt32(palavra);

            try
            {

                numero = Convert.ToInt32(palavra);
            }
            catch (Exception ex) //dentro da exceção pode criar um variável Ex.: ex.
            {
                MessageBox.Show("Aconteceu um erro." + ex.Message); // Inutilizando o throw ele mostra o erro no msgbox.

                //throw;
            }
        }

        private void btnTeste2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = localhost; Initial Catalog = BDSistemaExemplo2; User ID = sa; Password = 3s4mc"; //Se estiver usando PC de Casa colocar no User ID: Integrated Security = true"

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO Jogos VALUES (@nmJogo)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nmJogo", txtJogo.Text);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Foi inserido com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); // Com o "Erro" depois da , e os demais componentes manipulam como vai exibir o erro.
                //throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) // Usa-se somente na DAL para não fechar uma conexão que não foi aberta, poupando memória.
                {
                    conn.Close();
                    MessageBox.Show("A conexão foi fechada.");
                }
            }
        }
    }
}
