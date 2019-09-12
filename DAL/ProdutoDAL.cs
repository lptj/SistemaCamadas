using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    public class ProdutoDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDSistemaExemploConnectionString"].ConnectionString;
        public void InserirProduto(Produto objProduto)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "INSERT INTO Produtos VALUES (@dsProduto, @vlUnitario, @cdCategoria)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@dsProduto", objProduto.DsProduto);
            cmd.Parameters.AddWithValue("@vlUnitario", objProduto.VlUnitario);
            cmd.Parameters.AddWithValue("@cdCategoria", objProduto.CdCategoria);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Produto BuscarProdutoPeloCodigo(int cdProduto)
        {
            Produto objProduto = null;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM Produtos WHERE CdProduto = @codigo";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", cdProduto);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    objProduto = new Produto();
                    objProduto.CdProduto = cdProduto;
                    objProduto.DsProduto = dr["DsProduto"].ToString();
                    objProduto.VlUnitario = Convert.ToDecimal(dr["vlUnitario"]);
                    objProduto.CdCategoria = Convert.ToInt32(dr["CdCategoria"]);
                }
            }
            conn.Close();
            return objProduto;
        }
    }
}
