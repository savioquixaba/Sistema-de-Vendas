using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasCRUD.Models
{
    public class Venda
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataVenda { get; set; }
        public string ProdutoVendido { get; set; }
        public string Email { get; set; }
        public string NumeroTelefone { get; set; }
    }
}
