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
			Map(v => v.Documento).Name("documento");
			Map(v => v.RazaoSocial).Name("razao_social");
			Map(v => v.CEP).Name("cep");
			Map(v => v.Produto).Name("produto");
			Map(v => v.NumerodoPedido).Name("numero_pedido");
			Map(v => v.Data).Name("data_pedido");
		}
	}
}
