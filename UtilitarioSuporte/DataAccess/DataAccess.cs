using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using UtilitarioSuporte.DataAccess;
using UtilitarioSuporte.Negocio;

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
        public static bool TestarConexao(string stringConexao)
        {
            NpgsqlConnection conn = new NpgsqlConnection(stringConexao);
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (NpgsqlException)
            {
                return false;
            }
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
            catch
            {
                return null; 
            }
        }
        public static DataTable ConectarBancoDados(string conexao)
        {
            NpgsqlConnection conn;
            DataTable empresas;
            conn = Conexao.ConexaoBase(conexao);
            empresas = ConsultarEmpresas(conn);
            return empresas;
        }
        public static DataTable ConsultarEmpresas(NpgsqlConnection conn)
        {
            NpgsqlCommand empresas = ComandosSQL.CmdEmpresas(conn);
            DataTable dtEmpresas = Conexao.ExecReader(empresas, conn);
            return dtEmpresas;
        }
        public static string SalvarConfiguracaoBaseDados(string servidor, string porta, string baseDados, string usuario, string senha, int idEmpresa)
        {
            string conexao = Funcoes.MontaStringConexao(servidor, porta, baseDados, usuario, senha);
            return conexao;
        }
        public static DataTable PreencherDataTable(string mes, string ano, int tipo)
        {
            try
            {
                List<string> informacaoConfiguracao = Funcoes.DescriptografarStringConexao();
                NpgsqlConnection conn = Conexao.ConexaoBase(informacaoConfiguracao[0]);
                NpgsqlCommand comando;
                comando = ComandosSQL.CmdConsultarNotasNFe(conn, mes, ano, tipo, informacaoConfiguracao[1]);
                DataTable dataTableNotas = Conexao.ExecReader(comando, conn);
                return dataTableNotas;
            }
            catch
            {
                return null;
            }   
        }
        public static void ConsultaEmpresaBancoDados(string dadosBancoDados, string idEmpresa)
        {
            NpgsqlConnection conn = Conexao.ConexaoBase(dadosBancoDados);
            NpgsqlCommand comando;
            comando = ComandosSQL.CmdConsultarEmpresa(conn, idEmpresa);
        }
        public static bool Restore(string executavelPsql, string caminhoBaseDados, string usuario, string bancoDados, string senha, string stringConexao)
        {
            string argumentoRecuperacao = $"-U {usuario} -d {bancoDados} -f \"{caminhoBaseDados}\"";
            Environment.SetEnvironmentVariable("PGPASSWORD", senha);
            string exe = executavelPsql + @"\psql";
            string arg = argumentoRecuperacao;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = exe;
            startInfo.Arguments = arg;
            try
            {
                bool nomeTeste = CriarDataBase(stringConexao, bancoDados);
                if (nomeTeste == true)
                {
                    Process exeProcess = Process.Start(startInfo);
                    exeProcess.WaitForExit();
                    return true;
                }
                else
                {                                      
                    return false;
                }

            }
            catch
            {
                MessageBox.Show(@"Selecione a pasta do PSQL Corretamente ex:C\programfiles(x86)\Postgres\x.x\bin", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
        public static bool CriarDataBase(string stringConexao, string baseDados)
        {
            NpgsqlConnection conn = new NpgsqlConnection(stringConexao);
            try
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand($"CREATE DATABASE {baseDados}", conn);
                command.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

