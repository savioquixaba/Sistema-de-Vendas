using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendasCRUD.Database;

namespace VendasCRUD
{
    public partial class ListarVendas : Form
    {
        public ListarVendas()
        {
            InitializeComponent();
        }

        private void ListarVendas_Load(object sender, EventArgs e)
        {
            var vendRep = new VendaRep();
            var vendas = vendRep.ConsultarVendas();
            MessageBox.Show("Quantidade de vendas retornadas: " + vendas.Count);
            dataGridViewListar.AutoGenerateColumns = true;
            dataGridViewListar.DataSource = vendas;
            //dataGridViewListar.DataSource = vendas;

            //dataGridViewListar.Columns.Clear();

            //dataGridViewListar.Columns.Add("IdCliente", "ID Cliente");
            //dataGridViewListar.Columns.Add("NomeCliente", "Nome Cliente");
            //dataGridViewListar.Columns.Add("DataVenda", "Data Venda");
            //dataGridViewListar.Columns.Add("ProdutoVendido", "Produto Vendido");
            //dataGridViewListar.Columns.Add("Email", "Email");
            //dataGridViewListar.Columns.Add("NumeroTelefone", "Número Telefone");
            if (vendas.Count == 0)
            {
                MessageBox.Show("Nenhuma venda encontrada.");
            }
            else
            {
                dataGridViewListar.DataSource = vendas;
            }
        }

        private void dataGridViewListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
