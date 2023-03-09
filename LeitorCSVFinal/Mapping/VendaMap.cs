using CsvHelper.Configuration;
using LeitorCSVFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeitorCSVFinal.Mapping
{
    public class VendaMap : ClassMap<Venda>
	{
		public VendaMap() 
		{
			Map(v => v.Documento).Name("Documento");
			Map(v => v.RazaoSocial).Name("RazaoSocial");
			Map(v => v.CEP).Name("CEP");
			Map(v => v.Produto).Name("Produto");
			Map(v => v.NumerodoPedido).Name("Numerodopedido");
			Map(v => v.Data).Name("Data");
		}
	}
}
