using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration; //Para acessar o app.config
using Models;
using System.Data.SqlClient; //Para acessar o SQL

namespace DAL
{
    public class FotoDAL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BDSistemaExemploConnectionString"].ConnectionString; //Primeiro comando para acessar a DAL.

        public void InserirFoto(Foto objFoto)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "INSERT INTO Fotos VALUES (@dsTitulo, @nmArquivo)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@dsTitulo", objFoto.DsTitulo);
            cmd.Parameters.AddWithValue("@nmArquivo", objFoto.NmArquivo);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Foto> ListarFotos()
        {
            List<Foto> listaFotos = new List<Foto>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM Fotos";

            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Foto objFoto;
                while (dr.Read())
                {
                    objFoto = new Foto();
                    objFoto.CdFoto = Convert.ToInt32(dr["CdFoto"]);
                    objFoto.DsTitulo = dr["DsTitulo"].ToString();
                    objFoto.NmArquivo = dr["NmArquivo"].ToString();

                    listaFotos.Add(objFoto);
                }
            }
            conn.Close();
            return listaFotos;
        }

        public Foto SelecionarFotoPeloCodigo(int cdFoto)
        {
            Foto objFoto = null;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM Fotos WHERE CdFoto = @cdfoto";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cdfoto", cdFoto);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    objFoto = new Foto();
                    objFoto.CdFoto = Convert.ToInt32(dr["CdFoto"]);
                    objFoto.DsTitulo = dr["DsTitulo"].ToString();
                    objFoto.NmArquivo = dr["NmArquivo"].ToString();
                }
            }
            conn.Close();
            return objFoto;
        }
    }
}
