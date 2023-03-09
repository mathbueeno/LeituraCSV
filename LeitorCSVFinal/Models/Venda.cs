using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LeitorCSVFinal.Models
{
    public class Venda
    {
        public string Documento { get; set; }
        public string RazaoSocial { get; set; }
        public int CEP { get; set; }
        public string Produto { get; set; }
        public int NumerodoPedido { get; set; }
        public DateTime Data { get; set; }
    }
}
