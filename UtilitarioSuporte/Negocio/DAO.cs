using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitarioSuporte.Negocio
{
    public class DAO
    {
        public static void PreencherFormulario(string mes, string ano, int tipo)
        {
            string informacaoConfiguracao = Funcoes.DescriptografarStringConexaoAsync().ToString();
            string conexao = informacaoConfiguracao.Substring(0, informacaoConfiguracao.IndexOf("|"));


        }
    }
}
