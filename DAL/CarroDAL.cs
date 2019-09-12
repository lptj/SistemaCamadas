using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class CarroDAL
    {
        //Foi colocado a Connection String na propriedade da Classe para poder ler de qualquer scopo de código
        //Fazer o código para acessar o banco de dados, seja Oracle ou SQL, etc. (Abaixo o código)
        //string connectionString = "Data Source=localhost; Initial Catalog=BDSistemaExemplo; Integrated Security=true"; (CONFIGURAR ASSIM PARA USAR EM CASA)
        //string connectionString = "Data Source=localhost; Initial Catalog=BDSistemaExemplo; User ID=sa; Password=3s4mc";
        string connectionString = ConfigurationManager.ConnectionStrings["BDSistemaExemploConnectionString"].ConnectionString;
        public void InserirCarro(Carro objCarro)
        {
            

            //Código abaixo cria um objeto de conexão com o banco de dados
            SqlConnection conn = new SqlConnection(connectionString);

            //O código abaixo abre a conexão criada 
            conn.Open();

            //Criar o comando para execução
            string sql = "INSERT INTO Carros VALUES (@marca, @modelo, @cor, @ano)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            //Definir os parâmetros
            cmd.Parameters.AddWithValue("@marca", objCarro.DsMarca);
            cmd.Parameters.AddWithValue("@modelo", objCarro.DsModelo);
            cmd.Parameters.AddWithValue("@cor", objCarro.DsCor);
            cmd.Parameters.AddWithValue("@ano", objCarro.Ano);

            //Executar o comando (Execução que não vai ter retorno)
            cmd.ExecuteNonQuery();

            //Fechar a conexão
            conn.Close();
        }
        //Código abaixo é uma seleção para retornar um objeto carro
        public Carro SelecionarCarroPeloCodigo(int cdCarro)
        {
            //Criado como null por que em um momento vai ter que retornar ele
            Carro objCarro = null;

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Carros WHERE CdCarro = @codigo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@codigo", cdCarro);

            //O SqlDataReader serve para quando executa ele colher os dados pois no select vai precisar de retorno
            SqlDataReader dr = cmd.ExecuteReader();

            // O código abaixo pergunta se tem linha no banco de dados, se sim, é verdadeiro e vai continuar.
            if (dr.HasRows)
            {
                if (dr.Read())  // Este código le a proxima linha e se conseguir ler, volta como verdadeiro e joga no objeto
                {
                    objCarro = new Carro();
                    objCarro.CdCarro = cdCarro;
                    objCarro.DsMarca = dr["DsMarca"].ToString();
                    objCarro.DsModelo = dr["DsModelo"].ToString();
                    objCarro.DsCor = dr["DsCor"].ToString();
                    objCarro.Ano = Convert.ToInt32(dr["Ano"]);

                }
            }

            conn.Close();

            return objCarro;
        }

        public void Atualizar(Carro objCarro)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "UPDATE Carros SET DsMarca = @ma, DsModelo = @mo, DsCor = @cor, Ano = @ano WHERE CdCarro = @codigo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ma", objCarro.DsMarca);
            cmd.Parameters.AddWithValue("@mo", objCarro.DsModelo);
            cmd.Parameters.AddWithValue("@cor", objCarro.DsCor);
            cmd.Parameters.AddWithValue("@ano", objCarro.Ano);
            cmd.Parameters.AddWithValue("@codigo", objCarro.CdCarro);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void Excluir (int cdCarro)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Carros WHERE CdCarro = @cdcarro";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@cdcarro", cdCarro);

            cmd.ExecuteNonQuery(); // Usar esse por que não vai ler nada (não retorna valor) e sim executar no banco

            conn.Close();
        }

        // Còdigo abaixo vai exibir uma lista com todos carros existentes - List por que é uma array dinamica
        public List<Carro> SelecionarTodosCarros()
        {
            // É possível instanciar 2 objetos iguais e manda-los para lista pois quando se instancía novamente ele guarda em outro espaço de memoria
            // É importa criar a lista vazia e não nula para caso resolver buscar e estiver vazia ele mostre ela mesmo assim
            List<Carro> listaCarros = new List<Carro>();

            //Carro objCarro = null;
            //objCarro = new Carro();
            //objCarro.DsMarca = "VW";

            //listaCarros.Add(objCarro);

            //objCarro = new Carro();
            //objCarro.DsMarca = "GM";

            //listaCarros.Add(objCarro);

            //objCarro = new Carro();
            //objCarro.DsMarca = "Ferrari";

            //listaCarros.Add(objCarro);

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM Carros";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                // A váriavel abaixo faz função de auxiliar para poder replicar a cada vez que instancia
                // É importante manter a váriavel auxiliar fora do while para reservar o espaço na memória uma única vez
                Carro objCarro;
                while(dr.Read())
                {
                    objCarro = new Carro();
                    objCarro.CdCarro = Convert.ToInt32(dr["CdCarro"]);
                    objCarro.DsMarca = dr["DsMarca"].ToString();
                    objCarro.DsModelo = dr["DsModelo"].ToString();
                    objCarro.DsCor = dr["DsCor"].ToString();
                    objCarro.Ano = Convert.ToInt32(dr["Ano"]);

                    listaCarros.Add(objCarro);
                }
            }

            conn.Close();
            return listaCarros;
        }
    }
}
