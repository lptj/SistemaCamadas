using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Configuration; //Para poder usar a connectionString e App.Config

namespace DAL
{
    public class JogoDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDSistemaExemploConnectionString"].ConnectionString;

        public void InserirJogo(Jogo objJogo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "INSERT INTO Jogos VALUES (@nmJogo)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nmJogo", objJogo.NmJogo);
                cmd.ExecuteNonQuery();

                conn.Close();

                //MessageBox.Show("Foi inserido com sucesso."); Não funciona MsgBox por que nãu usa tela e sim somente o acesso ao BD.
            }
            catch (Exception ex)
            {
                //O código abaixo Explode o erro original.
                throw ex;
                //O código abaixo explode um erro personalizado.
                //throw new Exception("Ihhh deu erro no Banco...");
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open) // Usa-se somente na DAL para não fechar uma conexão que não foi aberta, poupando memória.
                {
                    conn.Close();
                }
            }
        }

        public List<Jogo> BuscarTodosJogos()
        {
            List<Jogo> listaJogos = new List<Jogo>();

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Jogos";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    Jogo objJogo = null;
                    while(dr.Read())
                    {
                        objJogo = new Jogo();
                        objJogo.CdJogo = Convert.ToInt32(dr["CdJogo"]);
                        objJogo.NmJogo = dr["NmJogo"].ToString();
                        listaJogos.Add(objJogo);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
            }

            return listaJogos;
        }
    }
}
