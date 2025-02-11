namespace VendasCRUD
{
    partial class ListarVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewListar = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListar).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListar
            // 
            dataGridViewListar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewListar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListar.ColumnHeadersVisible = false;
            dataGridViewListar.GridColor = SystemColors.HighlightText;
            dataGridViewListar.Location = new Point(12, 92);
            dataGridViewListar.MultiSelect = false;
            dataGridViewListar.Name = "dataGridViewListar";
            dataGridViewListar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListar.Size = new Size(775, 346);
            dataGridViewListar.TabIndex = 0;
            dataGridViewListar.CellContentClick += dataGridViewListar_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26F);
            label1.Location = new Point(223, 24);
            label1.Name = "label1";
            label1.Size = new Size(317, 40);
            label1.TabIndex = 1;
            label1.Text = "LISTA DE VENDAS";
            // 
            // ListarVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(799, 450);
            Controls.Add(label1);
            Controls.Add(dataGridViewListar);
            Name = "ListarVendas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListarVendas";
            Load += ListarVendas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewListar;
        private Label label1;
    }
}