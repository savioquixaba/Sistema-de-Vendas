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
    public partial class FormNovaVenda : Form
    {
        public FormNovaVenda()
        {
            InitializeComponent();
        }

        private void FormNovaVenda_Load(object sender, EventArgs e)
        {
            campoData.Value = DateTime.Now;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            // Pega os dados dos campos de texto e do campo de data
            string nomeCliente = campoNome.Text;
            DateTime dataVenda = campoData.Value;
            string produtoVendido = campoProduto.Text;
            string email = campoEmail.Text;
            string numeroTelefone = campoTelefone.Text;

            if (string.IsNullOrWhiteSpace(nomeCliente) || string.IsNullOrWhiteSpace(produtoVendido) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(numeroTelefone))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            var vendaRep = new VendaRep();

            vendaRep.InserirVenda(nomeCliente, dataVenda, produtoVendido, email, numeroTelefone);
            MessageBox.Show("Venda cadastrada com Sucesso!");
            LimparCampos();
        }
        private void LimparCampos()
        {

            campoNome.Clear();
            campoProduto.Clear();
            campoEmail.Clear();
            campoTelefone.Clear();
            campoData.Value = DateTime.Now;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
           DialogResult resultado = MessageBox.Show(
          "Tem certeza que deseja cancelar?",
          "Confirmar Cancelamento",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question
           );

            if (resultado == DialogResult.Yes)
            {
                this.Close(); // Fecha o formulário, é um form.close
            }
        }
    }
}
