namespace VendasCRUD
{
    partial class AtualizarVenda
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
            label1 = new Label();
            label2 = new Label();
            btnBusca = new Button();
            txtBusca = new TextBox();
            label3 = new Label();
            campoNome = new TextBox();
            campoTelefone = new MaskedTextBox();
            campoEmail = new TextBox();
            campoProduto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnConfirmar = new Button();
            campoData = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 29);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 26F, FontStyle.Bold);
            label2.Location = new Point(278, 29);
            label2.Name = "label2";
            label2.Size = new Size(239, 40);
            label2.TabIndex = 2;
            label2.Text = "Editar Venda";
            label2.Click += label2_Click;
            // 
            // btnBusca
            // 
            btnBusca.Location = new Point(45, 247);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(114, 29);
            btnBusca.TabIndex = 3;
            btnBusca.Text = "Buscar venda";
            btnBusca.UseVisualStyleBackColor = true;
            btnBusca.Click += btnBusca_Click;
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(45, 201);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(110, 23);
            txtBusca.TabIndex = 4;
            txtBusca.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 164);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 5;
            label3.Text = "Digite o ID da venda ";
            // 
            // campoNome
            // 
            campoNome.Location = new Point(472, 124);
            campoNome.Name = "campoNome";
            campoNome.Size = new Size(294, 23);
            campoNome.TabIndex = 6;
            // 
            // campoTelefone
            // 
            campoTelefone.Location = new Point(472, 334);
            campoTelefone.Mask = "(99) 00000-0000";
            campoTelefone.Name = "campoTelefone";
            campoTelefone.Size = new Size(85, 23);
            campoTelefone.TabIndex = 17;
            // 
            // campoEmail
            // 
            campoEmail.Location = new Point(472, 236);
            campoEmail.Name = "campoEmail";
            campoEmail.Size = new Size(294, 23);
            campoEmail.TabIndex = 18;
            // 
            // campoProduto
            // 
            campoProduto.Location = new Point(472, 176);
            campoProduto.Name = "campoProduto";
            campoProduto.Size = new Size(294, 23);
            campoProduto.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Arial", 13F);
            label4.Location = new Point(363, 124);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 21;
            label4.Text = "Nome :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Arial", 13F);
            label5.Location = new Point(281, 176);
            label5.Name = "label5";
            label5.Size = new Size(154, 23);
            label5.TabIndex = 22;
            label5.Text = "Produto Vendido :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Arial", 13F);
            label6.Location = new Point(366, 236);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 23;
            label6.Text = "Email :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Arial", 13F);
            label7.Location = new Point(372, 284);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 24;
            label7.Text = "Data :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Font = new Font("Arial", 13F);
            label8.Location = new Point(344, 334);
            label8.Name = "label8";
            label8.Size = new Size(91, 23);
            label8.TabIndex = 25;
            label8.Text = "Telefone :";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(635, 308);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(131, 49);
            btnConfirmar.TabIndex = 26;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // campoData
            // 
            campoData.Format = DateTimePickerFormat.Short;
            campoData.Location = new Point(472, 284);
            campoData.Name = "campoData";
            campoData.RightToLeft = RightToLeft.No;
            campoData.Size = new Size(118, 23);
            campoData.TabIndex = 27;
            campoData.Value = new DateTime(2025, 2, 11, 0, 0, 0, 0);
            // 
            // AtualizarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(campoData);
            Controls.Add(btnConfirmar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(campoProduto);
            Controls.Add(campoEmail);
            Controls.Add(campoTelefone);
            Controls.Add(campoNome);
            Controls.Add(label3);
            Controls.Add(txtBusca);
            Controls.Add(btnBusca);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AtualizarVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AtualizarVenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btnBusca;
        private TextBox txtBusca;
        private Label label3;
        private TextBox campoNome;
        private MaskedTextBox campoTelefone;
        private TextBox campoEmail;
        private TextBox campoProduto;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnConfirmar;
        private DateTimePicker campoData;
    }
}