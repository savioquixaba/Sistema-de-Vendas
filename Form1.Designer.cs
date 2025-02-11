namespace VendasCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            criarVenda = new Button();
            btnListarVendas = new Button();
            btnExcluirVenda = new Button();
            btnAtualizar = new Button();
            bemVindo = new Label();
            SuspendLayout();
            // 
            // criarVenda
            // 
            criarVenda.Location = new Point(26, 168);
            criarVenda.Name = "criarVenda";
            criarVenda.Size = new Size(115, 75);
            criarVenda.TabIndex = 0;
            criarVenda.Text = "Nova Venda";
            criarVenda.UseVisualStyleBackColor = true;
            criarVenda.Click += CriarVenda_Click;
            // 
            // btnListarVendas
            // 
            btnListarVendas.Location = new Point(201, 168);
            btnListarVendas.Name = "btnListarVendas";
            btnListarVendas.Size = new Size(115, 75);
            btnListarVendas.TabIndex = 4;
            btnListarVendas.Text = "Listar Vendas";
            btnListarVendas.UseVisualStyleBackColor = true;
            btnListarVendas.Click += btnListarVendas_Click;
            // 
            // btnExcluirVenda
            // 
            btnExcluirVenda.Location = new Point(368, 168);
            btnExcluirVenda.Name = "btnExcluirVenda";
            btnExcluirVenda.Size = new Size(115, 75);
            btnExcluirVenda.TabIndex = 5;
            btnExcluirVenda.Text = "Excluir Venda";
            btnExcluirVenda.UseVisualStyleBackColor = true;
            btnExcluirVenda.Click += btnExcluirVenda_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(532, 168);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(115, 75);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar Venda";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // bemVindo
            // 
            bemVindo.AutoSize = true;
            bemVindo.Font = new Font("Arial", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bemVindo.Location = new Point(254, 75);
            bemVindo.Name = "bemVindo";
            bemVindo.Size = new Size(169, 33);
            bemVindo.TabIndex = 7;
            bemVindo.Text = "Bem Vindo!";
            bemVindo.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(684, 450);
            Controls.Add(bemVindo);
            Controls.Add(btnAtualizar);
            Controls.Add(btnExcluirVenda);
            Controls.Add(btnListarVendas);
            Controls.Add(criarVenda);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button criarVenda;
        private Button btnListarVendas;
        private Button btnExcluirVenda;
        private Button btnAtualizar;
        private Label bemVindo;
    }
}
