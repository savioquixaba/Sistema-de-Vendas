﻿namespace VendasCRUD
{
    partial class FormNovaVenda
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
            campoNome = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            campoProduto = new TextBox();
            campoEmail = new TextBox();
            campoData = new DateTimePicker();
            label7 = new Label();
            cancelar = new Button();
            confirmar = new Button();
            id = new Label();
            campoTelefone = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 26F, FontStyle.Bold);
            label1.Location = new Point(219, 63);
            label1.Name = "label1";
            label1.Size = new Size(380, 40);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Vendas";
            label1.Click += label1_Click;
            // 
            // campoNome
            // 
            campoNome.Location = new Point(127, 146);
            campoNome.Name = "campoNome";
            campoNome.Size = new Size(456, 23);
            campoNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Arial", 13F);
            label3.Location = new Point(45, 146);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 4;
            label3.Text = "Nome :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Arial", 13F);
            label4.Location = new Point(45, 188);
            label4.Name = "label4";
            label4.Size = new Size(154, 23);
            label4.TabIndex = 5;
            label4.Text = "Produto Vendido :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Arial", 13F);
            label5.Location = new Point(48, 230);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 6;
            label5.Text = "Telefone :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Arial", 13F);
            label6.Location = new Point(48, 279);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 7;
            label6.Text = "Email :";
            // 
            // campoProduto
            // 
            campoProduto.Location = new Point(219, 188);
            campoProduto.Name = "campoProduto";
            campoProduto.Size = new Size(290, 23);
            campoProduto.TabIndex = 8;
            // 
            // campoEmail
            // 
            campoEmail.Location = new Point(138, 279);
            campoEmail.Name = "campoEmail";
            campoEmail.Size = new Size(393, 23);
            campoEmail.TabIndex = 9;
            // 
            // campoData
            // 
            campoData.CustomFormat = "dd/MM/yyyy";
            campoData.Format = DateTimePickerFormat.Custom;
            campoData.Location = new Point(205, 324);
            campoData.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            campoData.Name = "campoData";
            campoData.Size = new Size(83, 23);
            campoData.TabIndex = 11;
            campoData.Value = new DateTime(2025, 2, 7, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Arial", 13F);
            label7.Location = new Point(48, 324);
            label7.Name = "label7";
            label7.Size = new Size(130, 23);
            label7.TabIndex = 12;
            label7.Text = "Data da Venda";
            // 
            // cancelar
            // 
            cancelar.Location = new Point(189, 379);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(131, 49);
            cancelar.TabIndex = 13;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += cancelar_Click;
            // 
            // confirmar
            // 
            confirmar.Location = new Point(428, 379);
            confirmar.Name = "confirmar";
            confirmar.Size = new Size(131, 49);
            confirmar.TabIndex = 14;
            confirmar.Text = "Confirmar";
            confirmar.UseVisualStyleBackColor = true;
            confirmar.Click += confirmar_Click;
            // 
            // id
            // 
            id.AccessibleRole = AccessibleRole.None;
            id.AutoSize = true;
            id.Location = new Point(131, 111);
            id.Name = "id";
            id.Size = new Size(0, 15);
            id.TabIndex = 15;
            // 
            // campoTelefone
            // 
            campoTelefone.Location = new Point(157, 230);
            campoTelefone.Name = "campoTelefone";
            campoTelefone.Size = new Size(131, 23);
            campoTelefone.TabIndex = 16;
            // 
            // FormNovaVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(campoTelefone);
            Controls.Add(id);
            Controls.Add(confirmar);
            Controls.Add(cancelar);
            Controls.Add(label7);
            Controls.Add(campoData);
            Controls.Add(campoEmail);
            Controls.Add(campoProduto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(campoNome);
            Controls.Add(label1);
            Name = "FormNovaVenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Vendas";
            Load += FormNovaVenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox campoNome;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox campoProduto;
        private TextBox campoEmail;
        private DateTimePicker campoData;
        private Label label7;
        private Button cancelar;
        private Button confirmar;
        private Label id;
        private TextBox campoTelefone;
    }
}