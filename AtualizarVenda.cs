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
using VendasCRUD.Models;

namespace VendasCRUD
{
    public partial class AtualizarVenda : Form
    {
        public AtualizarVenda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBusca.Text, out int idCliente))
            {
                ConsultarVenda(idCliente);
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID válido.");
            }
        }
            private void ConsultarVenda(int idCliente)
            {
                var vendaRep = new VendaRep();
                var vendas = vendaRep.ConsultarVendas();
                
                //faz a verificação nas tabelas e retorna o primeiro ID igual o digitado
                var venda = vendas.FirstOrDefault(v => v.IdCliente == idCliente);
                if (venda != null)
                {
                    campoNome.Text = venda.NomeCliente;
                    campoProduto.Text = venda.ProdutoVendido;
                    campoEmail.Text = venda.Email;
                    campoTelefone.Text = venda.NumeroTelefone;
                    campoData.Value = venda.DataVenda;
                }
                else
                {
                    MessageBox.Show("Venda não encontrada.");
                }

        }
    
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Capturar o ID da venda
            if (!int.TryParse(txtBusca.Text, out int idVenda))
            {
                MessageBox.Show("ID da venda inválido. Por favor, insira um número válido.");
                return;
            }
            // Capturar os novos valores dos campos
            string nomeCliente = campoNome.Text;
            string produtoVendido = campoProduto.Text;
            string email = campoEmail.Text;
            string numeroTelefone = campoTelefone.Text;

            if (!DateTime.TryParse(campoData.Text, out DateTime dataVenda))
            {
                MessageBox.Show("Data inválida. Por favor, insira uma data válida no formato correto.");
                return;
            }

            var vendaAtualizada = new Models.Venda
            {
                IdCliente = idVenda,
                NomeCliente = nomeCliente,
                DataVenda = dataVenda,
                ProdutoVendido = produtoVendido,
                Email = email,
                NumeroTelefone = numeroTelefone
            };
            try
            {
                var vendRep = new VendaRep();
                vendRep.AtualizarVenda(vendaAtualizada);

                MessageBox.Show("Venda atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a venda: " + ex.Message);
            }







        }
    }
}

