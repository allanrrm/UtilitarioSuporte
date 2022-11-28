using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitarioSuporte.DataAccess
{
    public class ComandosSQL
    {
        public static NpgsqlCommand CmdEmpresas(NpgsqlConnection conn)
        {
            NpgsqlCommand empresas = new NpgsqlCommand("select id, nome_razao_social from pessoa inner join empresa e on pessoa.id = e.id_pessoa", conn);
            return empresas;
        }
    }
}
