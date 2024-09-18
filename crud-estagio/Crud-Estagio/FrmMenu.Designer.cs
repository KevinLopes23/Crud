namespace Crud_Estagio
{
    partial class Form1
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
            btnClientes = new Button();
            btnSair = new Button();
            btnPesquisa = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(39, 12);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(138, 50);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(39, 79);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(138, 46);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair ...";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += button2_Click;
            // 
            // btnPesquisa
            // 
            btnPesquisa.Location = new Point(39, 141);
            btnPesquisa.Name = "btnPesquisa";
            btnPesquisa.Size = new Size(138, 50);
            btnPesquisa.TabIndex = 2;
            btnPesquisa.Text = "Pesquisa";
            btnPesquisa.UseVisualStyleBackColor = true;
            btnPesquisa.Click += btnPesquisa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 450);
            Controls.Add(btnPesquisa);
            Controls.Add(btnSair);
            Controls.Add(btnClientes);
            Name = "Form1";
            Text = "FrmMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnSair;
        private Button btnPesquisa;
    }
}