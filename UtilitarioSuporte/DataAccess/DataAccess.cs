using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows;
using System.Xml;
using UtilitarioSuporte.DataAccess;
using UtilitarioSuporte.Negocio;
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
            }
            catch (Exception)
            {
                conn.Close();
            }
            return conn;

        }
        public static NpgsqlConnection CriarConexaoBase(string stringConexao)
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
        public static DataTable ConectarBancoDados(string servidor, string porta, string baseDados, string usuario, string senha)
        {
            string conexao = Funcoes.MontaStringConexao(servidor, porta, baseDados, usuario, senha);
            NpgsqlConnection conn = Conexao.CriarConexaoBase(conexao);
            DataTable empresas = ConsultarEmpresas(conn);
            return empresas;
        }
        public static DataTable ConsultarEmpresas(NpgsqlConnection conn)
        {
            NpgsqlCommand empresas = ComandosSQL.CmdEmpresas(conn);
            DataTable dtEmpresas = Conexao.ExecReader(empresas, conn);
            return dtEmpresas;
        }
        public static void SalvarConfiguracaoBaseDados(string servidor, string porta, string baseDados, string usuario, string senha, int idEmpresa)
        {
            string conexao = Funcoes.MontaStringConexao(servidor, porta, baseDados, usuario, senha);
            Funcoes.CriptografarConexaoBanco(conexao, idEmpresa);
        }
        public static DataTable PreencherFormularioDataTable(string mes, string ano, int tipo)
        {
            List<string> informacaoConfiguracao = Funcoes.DescriptografarStringConexao();
            NpgsqlConnection conn = Conexao.ConexaoBase(informacaoConfiguracao[0]);
            NpgsqlCommand comando = ComandosSQL.CmdConsultarNotasNFe(conn, mes, ano, tipo, informacaoConfiguracao[1]);
            DataTable dataTableNotas = Conexao.ExecReader(comando, conn);
            return dataTableNotas;

        }

    }
    }

