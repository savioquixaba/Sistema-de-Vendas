namespace VendasCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CriarVenda_Click(object sender, EventArgs e)
        {
            var formNovaVenda = new FormNovaVenda();
            formNovaVenda.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnListarVendas_Click(object sender, EventArgs e)
        {
            var ListarVendas = new ListarVendas();
            ListarVendas.ShowDialog();
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            var ExcluirVenda = new ExcluirVenda();
            ExcluirVenda.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var AtualizarVenda = new AtualizarVenda();
            AtualizarVenda.ShowDialog();
        }
    }
}
