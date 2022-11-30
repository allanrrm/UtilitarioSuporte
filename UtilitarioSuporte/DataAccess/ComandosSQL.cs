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


        public static NpgsqlCommand CmdConsultarNotasNFe(NpgsqlConnection conn, string mes, string ano, int tipo, string idEmpresa)
        {
            DateTime datainicial = DateTime.Parse("1." + mes + ano);
            DateTime datafinal = (datainicial.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59).AddSeconds(59));
            NpgsqlCommand notas;
            if (tipo == 2)
            {
                notas = new NpgsqlCommand("SELECT " +
                "ID, " +
                "NUMERO, " +
                "MODELO, " +
                "VALORTOTAL, " +
                "CANCELADO, " +
                "CHAVEACESSO, " +
                "XML, " +
                "RECIBO, " +
                "SERIE " +
                "FROM " +
                "NFCE " +
                "WHERE " +
                "MOVIMENTO BETWEEN " +
                "@DATAINICIAL AND " +
                "@DATAFINAL AND " +
                "IDEMPRESA = " +
                "@IDEMPRESA " +
                "ORDER BY 2", conn);
                notas.Parameters.AddWithValue("@DATAINICIAL", datainicial);
                notas.Parameters.AddWithValue("@DATAFINAL", datafinal);
                notas.Parameters.AddWithValue("@IDEMPRESA", int.Parse(idEmpresa));
            }
            else
            {
                notas = new NpgsqlCommand("SELECT " +
                "ID, " +
                "NUMERO, " +
                "MODELO, " +
                "TOTAL, " +
                "CANCELADO, " +
                "CHAVE_ACESSO, " +
                "XML " +
                "FROM " +
                "NOTA_FISCAL " +
                "WHERE " +
                "MOVIMENTO BETWEEN " +
                "@DATAINICIAL AND " +
                "@DATAFINAL AND " +
                "TIPO = " +
                "@TIPO AND " +
                "ID_EMPRESA = " +
                "@IDEMPRESA " +
                "ORDER BY 2", conn);
                notas.Parameters.AddWithValue("@DATAINICIAL", datainicial);
                notas.Parameters.AddWithValue("@DATAFINAL", datafinal);
                notas.Parameters.AddWithValue("@TIPO", tipo);
                notas.Parameters.AddWithValue("@IDEMPRESA", int.Parse(idEmpresa));

            }
            return notas;

        }




    }
}
