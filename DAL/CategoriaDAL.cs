using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class CategoriaDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDSistemaExemploConnectionString"].ConnectionString;

        public void InserirCategoria(Categoria objCategoria)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Categorias VALUES (@dscat)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@dscat", objCategoria.DsCategoria);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public List<Categoria> SelecionarTodasCategorias()
        {
            List<Categoria> listaCategorias = new List<Categoria>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM Categorias";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                //Código abaixo é um Objeto Auxiliar para jogar na lista
                Categoria objCategoria;
                while (dr.Read())
                {
                    objCategoria = new Categoria();
                    objCategoria.cdCategoria = Convert.ToInt32(dr["CdCategoria"]);
                    objCategoria.DsCategoria = dr["DsCategoria"].ToString();

                    listaCategorias.Add(objCategoria);
                }
                conn.Close();
            }
            return listaCategorias;
        }

        public Categoria BuscarCategoriaPeloCodigo(int CdCategoria)
        {
            Categoria objCategoria = null;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM Categorias WHERE CdCategoria = @codigo";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", CdCategoria);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    objCategoria = new Categoria();
                    objCategoria.cdCategoria = CdCategoria;
                    objCategoria.DsCategoria = dr["DsCategoria"].ToString();
                }
            }
            conn.Close();
            return objCategoria;
        }

        public void Atualizar()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //string sql = "UPDATE Categorias SET "
            //CONTINUAR FAZENDO BOTOES
        }
    }
}
