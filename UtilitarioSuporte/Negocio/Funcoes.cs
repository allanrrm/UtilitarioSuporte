using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using Npgsql;
using System.Security.Cryptography;
using System.Data;
using UtilitarioSuporte.DataAccess;

namespace UtilitarioSuporte.Negocio
{
    public static class Funcoes
    {

        public static DataTable ConectarBancoDados(string servidor, string porta, string baseDados, string usuario, string senha)
        {
            string conexao = MontaStringConexao(servidor, porta, baseDados, usuario, senha);
            NpgsqlConnection conn = Conexao.ConexaoBase(conexao);
            DataTable empresas = ConsultarEmpresas(conn);
            return empresas ;
        }

        public static DataTable ConsultarEmpresas(NpgsqlConnection conn)
        {
                NpgsqlCommand empresas = ComandosSQL.CmdEmpresas(conn);
                DataTable dtEmpresas = Conexao.ExecReader(empresas, conn);
                return dtEmpresas;
        }

        public static void SalvarConfiguracaoBaseDados(string servidor, string porta, string baseDados, string usuario, string senha, int idEmpresa)
        {
            string conexao = MontaStringConexao(servidor, porta, baseDados, usuario, senha);
            CriptografarConexaoBanco(conexao, idEmpresa);
        }

        public static string DescriptografarStringConexaoAsync()
        {
            string conexao = DescriptografarConexaoBanco().ToString();
            return conexao;
        }

        private static string MontaStringConexao(string servidor, string porta, string baseDados, string usuario, string senha)
        {
            StringBuilder StringConexao = new StringBuilder();
            StringConexao.Append($"User Id={usuario};")
                .Append($"Password={senha};")
                .Append($"Server={servidor};")
                .Append($"Port={porta};")
                .Append($"Database={baseDados};")
                .Append($"Enlist=true;")
                .Append($"Timeout={5};"); //retirar
            return StringConexao.ToString();
        }

        private static void CriptografarConexaoBanco(string conexao, int idEmpresa)
        {
            try
            {
                using (FileStream fileStream = new FileStream(Environment.CurrentDirectory + @"\conexao.txt", FileMode.OpenOrCreate))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] key =
                        {
                            0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                            0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
                        };
                        aes.Key = key;

                        byte[] iv = aes.IV;
                        fileStream.Write(iv, 0, iv.Length);

                        using (CryptoStream cryptoStream = new CryptoStream(
                            fileStream,
                            aes.CreateEncryptor(),
                            CryptoStreamMode.Write))
                        {
                            using (StreamWriter encryptWriter = new StreamWriter(cryptoStream))
                            {
                                encryptWriter.WriteLine(conexao+"|"+idEmpresa);
                            }
                        }
                    }
                }
                MessageBox.Show("Configuração Salva com sucesso", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Conexão não foi salva, contate o administrador", "Aviso", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private static string DescriptografarConexaoBanco()
        {
            try
            {
                using (FileStream fileStream = new FileStream(Environment.CurrentDirectory + @"\conexao.txt", FileMode.Open))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] iv = new byte[aes.IV.Length];
                        int numBytesToRead = aes.IV.Length;
                        int numBytesRead = 0;
                        while (numBytesToRead > 0)
                        {
                            int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                            if (n == 0) break;

                            numBytesRead += n;
                            numBytesToRead -= n;
                        }

                        byte[] key =
                        {
                0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
            };

                        using (CryptoStream cryptoStream = new CryptoStream(
                           fileStream,
                           aes.CreateDecryptor(key, iv),
                           CryptoStreamMode.Read))
                        {
                            using (StreamReader decryptReader = new StreamReader(cryptoStream))
                            {
                               string decryptedMessage =  decryptReader.ReadToEnd();
                               return decryptedMessage;
                            }

                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"The decryption failed. {ex}");
                return null;
            }
        }
        
    }
}
