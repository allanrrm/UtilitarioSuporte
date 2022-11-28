using Npgsql;
using System;
using System.Data;
using System.Windows;
using static UtilitarioSuporte.Recursos.MessageBoxPersonalizada;

namespace DataAccess
{
    public class Conexao
    {
        public Conexao()
        {

        }

        public static NpgsqlConnection ConexaoBase(string stringConexao)
        {

            var conn = new NpgsqlConnection(stringConexao);
            try
            {
                conn.Open();
                MessageBox.Show("Conexão efetuada com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                conn.Close();
                MessageBox.Show("Não foi possivel estabelecer uma conexao com o servidor, verifique as informações e tente novamente.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
                return conn;

        }

        public static bool CriarConexaoBase(string stringConexao)
        {

            var conn = new NpgsqlConnection(stringConexao);
            bool ativar;
            try
            {
                conn.Open();
                MessageBox.Show("Conexão efetuada com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                ativar = true;
            }
            catch (Exception)
            {
                conn.Close();
                MessageBox.Show("Não foi possivel estabelecer uma conexao com o servidor, verifique as informações e tente novamente.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                ativar = false;
            }
                return ativar;          

        }

        public int contarNotas(NpgsqlCommand contarNotas)
        {
            int numeroNotas = Convert.ToInt32(contarNotas.ExecuteScalar());
            return numeroNotas;
        }

        public static DataTable ExecReader(NpgsqlCommand cmd, NpgsqlConnection conn)
        {
            try
            {
                cmd.Connection = conn;
                NpgsqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
