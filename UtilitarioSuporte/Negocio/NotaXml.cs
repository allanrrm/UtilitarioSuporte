﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitarioSuporte.Negocio
{
    public class NotaXml
    {
        public int NumeroNotas { get; set; }
        public int Autorizadas { get; set; }
        public int Canceladas { get; set; }
        public int Saltadas { get; set; }
        public double ValorTotal { get; set; }
        public double ValorTotalXml { get; set; }
        public int NotasComXml { get; set; }
        public DataTable DataTableNotas { get; set; }
        public DataTable DataTableNotasXml { get; set; }
        public DataTable DataTableSerie { get; set; }
        public NotaXml()
        {

        }
        public void ExtrairResultadosNFe(DataTable dataTableNotas)
        {
            NumeroNotas = dataTableNotas.AsEnumerable().Select(s => s.Field<int>("numero")).Count();
            Autorizadas = dataTableNotas.AsEnumerable().Where(x => x.Field<bool>("cancelado") == false).Select(s => s.Field<int>("numero")).Count();
            Canceladas = dataTableNotas.AsEnumerable().Where(x => x.Field<bool>("cancelado") == true).Select(s => s.Field<int>("numero")).Count();
            ValorTotal = (double)dataTableNotas.AsEnumerable().Where(x => x.Field<bool>("cancelado") == false).Select(s => s.Field<decimal>("total")).Sum();
            NotasComXml = dataTableNotas.AsEnumerable().Where(x => x.Field<object>("xml") != null).Select(s => s.Field<int>("numero")).Count();
            DataTableNotas = dataTableNotas.Copy();

        }
        public void ExtrairResultadosNFCe(DataTable dataTableNotas)
        {
            NumeroNotas = dataTableNotas.AsEnumerable().Select(s => s.Field<int>("numero")).Count();
            Autorizadas = dataTableNotas.AsEnumerable().Where(x => x.Field<bool>("cancelado") == false).Select(s => s.Field<int>("numero")).Count();
            Canceladas = dataTableNotas.AsEnumerable().Where(x => x.Field<bool>("cancelado") == true).Select(s => s.Field<int>("numero")).Count();
            ValorTotal = (double)dataTableNotas.AsEnumerable().Where(x => x.Field<bool>("cancelado") == false).Select(s => s.Field<decimal>("valortotal")).Sum();
            NotasComXml = dataTableNotas.AsEnumerable().Where(x => x.Field<object>("xml") != null).Select(s => s.Field<int>("numero")).Count();
            DataTableNotas = dataTableNotas.Copy();

        }
        public void AgruparValorPorSerie(DataTable dataTableNotas)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Serie", typeof(string));
            dt.Columns.Add("ValorTotal", typeof(decimal));
            
            foreach (DataRow dr in dataTableNotas.Rows)
            {
                dt.Rows.Add(new object[] { dr["Serie"], dr["ValorTotal"] });
            }

           var obj = from b in dt.AsEnumerable()
                     group b by b.Field<string>("Serie") into g
                     select new
                     {
                         Serie = g.Key,
                         List = g.ToList(),
                     } into g
                     select new
                     {
                         g.Serie,
                         Count = g.List.Count,
                         ValorTotal = g.List.Sum(x => x.Field<decimal>("ValorTotal"))
                     };


            DataTable dtab = new DataTable();
            dtab.Columns.Add("Serie", typeof(string));
            dtab.Columns.Add("ValorTotal", typeof(decimal));
            
            foreach (var drow in obj)
            {
                dtab.Rows.Add(drow.Serie,drow.ValorTotal);
            }

            DataTableSerie = dtab.Copy();

        }
        public void CalcularValorXml(DataTable dataTableNotas, int tipo)
        {
            ValorTotalXml = (double)dataTableNotas.AsEnumerable().Select(s => s.Field<decimal>("valor")).Sum();
        }

    }
}