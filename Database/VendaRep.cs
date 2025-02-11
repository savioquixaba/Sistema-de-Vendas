using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VendasCRUD.Database
{
    public class VendaRep
    {
        private readonly Data _connection;

        public VendaRep()
        {
            _connection = new Data();
        }

        public void InserirVenda(string nomeCliente, DateTime dataVenda, string produtoVendido, string email,string numeroTelefone)
        {
            using (var conn = _connection.GetConnection()) 
            {
                try
                {
                    conn.Open();
                    var insercao = "INSERT INTO vendas (nome_cliente, data_venda, produto_vendido, email, numero_telefone) VALUES (@nome_cliente, @data_venda, @produto_vendido, @email, @numero_telefone)";
                    using (var command = new NpgsqlCommand(insercao, conn))
                    {
                        command.Parameters.AddWithValue("nome_cliente", nomeCliente);
                        command.Parameters.AddWithValue("data_venda", dataVenda);
                        command.Parameters.AddWithValue("produto_vendido", produtoVendido);
                        command.Parameters.AddWithValue("email", email);
                        command.Parameters.AddWithValue("numero_telefone", numeroTelefone);

                        command.ExecuteNonQuery();
                    }
                    Console.WriteLine("Venda Inserida com Sucesso!");
                }
                catch (Exception ex)
                {
                    
                        MessageBox.Show("Erro ao inserir venda: " + ex.Message); // Exibe o erro na interface
                        Console.WriteLine("Erro detalhado: " + ex.ToString()); // Mantém o log para debug
                   
                }
            }
        }

        public List<Models.Venda> ConsultarVendas()
        {
            var Vendas = new List<Models.Venda>();
            using (var conn = _connection.GetConnection())
            {
                try
                {
                    conn.Open();
                    var leitura = "SELECT id_cliente, nome_cliente, data_venda, produto_vendido, email, numero_telefone FROM vendas;";
                    using (var command = new NpgsqlCommand(leitura, conn))
                    {
                        var lendo = command.ExecuteReader();
                        while (lendo.Read())
                        {
                            var venda = new Models.Venda

                            {
                                IdCliente = lendo.GetInt32(0),
                                NomeCliente = lendo.GetString(1),
                                DataVenda = lendo.GetDateTime(2),
                                ProdutoVendido = lendo.GetString(3),
                                Email = lendo.GetString(4),
                                NumeroTelefone = lendo.GetString(5)
                            };
                            Vendas.Add(venda);
                        }
                    }


                }
                catch (Exception ex)
                {
                    { Console.WriteLine("Erro ao consultar vendas: " + ex.Message); }

                }
            } return Vendas;
        }
        public void AtualizarVenda(Models.Venda venda)
        {
            using (var conn = _connection.GetConnection())
            {
                conn.Open();
                var command = new NpgsqlCommand("UPDATE vendas SET nome_cliente = @NomeCliente, data_venda = @DataVenda, produto_vendido = @ProdutoVendido, email = @Email, numero_telefone = @NumeroTelefone WHERE id_cliente = @IdCliente", conn);

                command.Parameters.AddWithValue("@NomeCliente", venda.NomeCliente);
                command.Parameters.AddWithValue("@DataVenda", venda.DataVenda);
                command.Parameters.AddWithValue("@ProdutoVendido", venda.ProdutoVendido);
                command.Parameters.AddWithValue("@Email", venda.Email);
                command.Parameters.AddWithValue("@NumeroTelefone", venda.NumeroTelefone);
                command.Parameters.AddWithValue("@IdCliente", venda.IdCliente);

                command.ExecuteNonQuery();
            }

        }
        public void DeletarVenda(int idCliente)
        {
            using (var conn = _connection.GetConnection()) 
            {
                try
                {
                    conn.Open();
                    var exclusao = "DELETE FROM vendas WHERE id_cliente = @IdCliente";
                    using (var command = new NpgsqlCommand(exclusao, conn))
                    {
                        command.Parameters.AddWithValue("@IdCliente",idCliente);
                        var linhasAfetadas = command.ExecuteNonQuery();
                        if(linhasAfetadas > 0)
                        { Console.WriteLine("A Exclusão foi um sucesso!"); }
                        else
                        {
                            Console.WriteLine("Nenhuma venda com ID informado existente!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao deletar venda: " + ex.Message);
                }
            }
        }

    }   


}
