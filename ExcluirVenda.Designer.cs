namespace VendasCRUD
{
    partial class ExcluirVenda
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
            dataGridViewVendas = new DataGridView();
            btnExcluir = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewVendas
            // 
            dataGridViewVendas.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVendas.Location = new Point(12, 122);
            dataGridViewVendas.Name = "dataGridViewVendas";
            dataGridViewVendas.Size = new Size(770, 311);
            dataGridViewVendas.TabIndex = 0;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Gray;
            btnExcluir.Location = new Point(641, 58);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(129, 41);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26F, FontStyle.Bold);
            label1.Location = new Point(245, 21);
            label1.Name = "label1";
            label1.Size = new Size(321, 41);
            label1.TabIndex = 2;
            label1.Text = "EXCLUIR VENDAS";
            // 
            // ExcluirVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(801, 450);
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(dataGridViewVendas);
            Name = "ExcluirVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExcluirVenda";
            Load += ExcluirVenda_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewVendas;
        private Button btnExcluir;
        private Label label1;
    }
}