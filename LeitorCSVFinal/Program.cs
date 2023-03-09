using CsvHelper;
using CsvHelper.Configuration;
using LeitorCSVFinal.Mapping;
using LeitorCSVFinal.Models;
using System.Globalization;

var config = new CsvConfiguration(CultureInfo.InvariantCulture)
{
	HasHeaderRecord = true,
};

using (var reader = new StreamReader("../../../teste.csv"))
using (var csv = new CsvReader(reader, config))
{
	csv.Context.RegisterClassMap<VendaMap>();

	var vendas = csv.GetRecords<Venda>();

	foreach (var venda in vendas)
	{
		Console.WriteLine($" Razao Social: {venda.RazaoSocial}");
	}
}
	Console.Read();


// CEP: {venda.CEP}, Produto: {venda.Produto}, Numero do Pedido: {venda.NumerodoPedido}, Data: {venda.Data}