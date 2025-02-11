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
    public partial class ExcluirVenda : Form
    {
        public ExcluirVenda()
        {
            InitializeComponent();
        }

        private void ExcluirVenda_Load(object sender, EventArgs e)
        {
            var vendaRep = new VendaRep();

            var vendas = vendaRep.ConsultarVendas();

            dataGridViewVendas.DataSource = vendas;
            dataGridViewVendas.AutoGenerateColumns = true;
            //dataGridViewVendas.Columns.Clear();

            //dataGridViewVendas.Columns.Add("IdCliente", "ID Cliente");
            //dataGridViewVendas.Columns.Add("NomeCliente", "Nome Cliente");
            //dataGridViewVendas.Columns.Add("DataVenda", "Data Venda");
            //dataGridViewVendas.Columns.Add("ProdutoVendido", "Produto Vendido");
            //dataGridViewVendas.Columns.Add("Email", "Email");
            //dataGridViewVendas.Columns.Add("NumeroTelefone", "Número Telefone");

            if (vendas.Count == 0)
            {
                MessageBox.Show("Nenhuma venda encontrada.");
            }
            else
            {
                dataGridViewVendas.DataSource = vendas;
            }
        }
        private void AtualizarVendas()
        {
            
            var vendaRep = new VendaRep();

            
            var vendas = vendaRep.ConsultarVendas();

            
            dataGridViewVendas.DataSource = vendas;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewVendas.SelectedRows.Count > 0)
            {
                
                var result = MessageBox.Show("Tem certeza que deseja excluir esta venda?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    
                    int idCliente = Convert.ToInt32(dataGridViewVendas.SelectedRows[0].Cells["IdCliente"].Value);

                    var vendaRep = new VendaRep();

                    vendaRep.DeletarVenda(idCliente);

                    AtualizarVendas();
                }
            }
            else
            {
                MessageBox.Show("Selecione uma venda para excluir.");
            }
        }
    }
}

