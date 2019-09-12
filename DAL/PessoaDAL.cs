using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class PessoaDAL
    {
        //string connectionString = "Data Source=localhost; Initial Catalog=BDSistemaExemplo; User ID=sa; Password=3s4mc";
        string connectionString = ConfigurationManager.ConnectionStrings["BDSistemaExemploConnectionString"].ConnectionString;
        public void InserirPessoa(Pessoa objPessoa)
        {
            

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Pessoas VALUES (@nome, @nasc, @email, @sexo, @estadocivil, @recemail, @recsms)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", objPessoa.Nome);
            cmd.Parameters.AddWithValue("@nasc", objPessoa.DtNasc);
            cmd.Parameters.AddWithValue("@email", objPessoa.Email);
            cmd.Parameters.AddWithValue("@sexo", objPessoa.Sexo);
            cmd.Parameters.AddWithValue("@estadocivil", objPessoa.EstadoCivil);
            cmd.Parameters.AddWithValue("@recemail", objPessoa.RecebeEmail);
            cmd.Parameters.AddWithValue("@recsms", objPessoa.RecebeSMS);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public List<Pessoa> BuscarPessoas(string nome)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM Pessoas WHERE DsNome LIKE @nome";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", "%" +  nome + "%");

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objPessoa;
                while (dr.Read())
                {
                    objPessoa = new Pessoa();
                    objPessoa.CdPessoa = Convert.ToInt32(dr["CdPessoa"]);
                    objPessoa.Nome = dr["DsNome"].ToString();
                    objPessoa.DtNasc = Convert.ToDateTime(dr["DtNasc"]);
                    objPessoa.Email = dr["Email"].ToString();
                    objPessoa.Sexo = dr["Sexo"].ToString();
                    objPessoa.EstadoCivil = dr["EstadoCivil"].ToString();
                    objPessoa.RecebeEmail = Convert.ToBoolean(dr["RecebeEmail"]);
                    objPessoa.RecebeSMS = Convert.ToBoolean(dr["RecebeSMS"]);

                    listaPessoas.Add(objPessoa);
                }
            }
            conn.Close();

            return listaPessoas;
        }
        public List<Pessoa> SelecionarTodasPessoas()
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM Pessoas";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Pessoa objPessoa;
                while(dr.Read())
                {
                    objPessoa = new Pessoa();
                    objPessoa.CdPessoa = Convert.ToInt32(dr["CdPessoa"]);
                    objPessoa.Nome = dr["DsNome"].ToString();
                    objPessoa.DtNasc = Convert.ToDateTime(dr["DtNasc"]);
                    objPessoa.Email = dr["Email"].ToString();
                    objPessoa.Sexo = dr["Sexo"].ToString();
                    objPessoa.EstadoCivil = dr["EstadoCivil"].ToString();
                    objPessoa.RecebeEmail = Convert.ToBoolean(dr["RecebeEmail"]);
                    objPessoa.RecebeSMS = Convert.ToBoolean(dr["RecebeSMS"]);

                    listaPessoas.Add(objPessoa);
                }
            }
            conn.Close();
            return listaPessoas;
        }

        public Pessoa SelecionarPessoaPeloCodigo(int cdPessoa)
        {
            Pessoa objPessoa = null;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM Pessoas WHERE CdPessoa = @codigo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", cdPessoa);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    objPessoa = new Pessoa();
                    objPessoa.CdPessoa = cdPessoa;
                    objPessoa.Nome = dr["DsNome"].ToString();
                    objPessoa.DtNasc = Convert.ToDateTime(dr["DtNasc"]);
                    objPessoa.Email = dr["Email"].ToString();
                    objPessoa.Sexo = dr["Sexo"].ToString();
                    objPessoa.EstadoCivil = dr["EstadoCivil"].ToString();
                    objPessoa.RecebeEmail = Convert.ToBoolean(dr["RecebeEmail"]);
                    objPessoa.RecebeSMS = Convert.ToBoolean(dr["RecebeSMS"]);
                }
            }
            conn.Close();
            return objPessoa;
        }
        public void Atualizar(Pessoa objPessoa)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "UPDATE Pessoas SET DsNome = @nome, DtNasc = @nasc, Email = @email, Sexo = @sexo, EstadoCivil = @estadociv, RecebeEmail = @recemail, RecebeSMS = @recsms WHERE CdPessoa = @codigo";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", objPessoa.CdPessoa);
            cmd.Parameters.AddWithValue("@nome", objPessoa.Nome);
            cmd.Parameters.AddWithValue("@nasc", objPessoa.DtNasc);
            cmd.Parameters.AddWithValue("@email", objPessoa.Email);
            cmd.Parameters.AddWithValue("@sexo", objPessoa.Sexo);
            cmd.Parameters.AddWithValue("@estadociv", objPessoa.EstadoCivil);
            cmd.Parameters.AddWithValue("@recemail", objPessoa.RecebeEmail);
            cmd.Parameters.AddWithValue("@recsms", objPessoa.RecebeSMS);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void Excluir(int CdPessoa)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "DELETE FROM Pessoas WHERE CdPessoa = @codigo";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@codigo", CdPessoa);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}               
