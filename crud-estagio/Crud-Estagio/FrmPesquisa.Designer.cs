namespace Crud_Estagio
{
    partial class FrmPesquisa
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
            txtFiltro = new ComboBox();
            txtBuscaPorFiltro = new TextBox();
            btnOk = new Button();
            dgPesquisa = new DataGridView();
            CODIGO = new DataGridViewTextBoxColumn();
            NOME = new DataGridViewTextBoxColumn();
            DATANASCIMENTO = new DataGridViewTextBoxColumn();
            IDADE = new DataGridViewTextBoxColumn();
            CIDADE = new DataGridViewTextBoxColumn();
            SEXO = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            btnCancelar = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPesquisa).BeginInit();
            SuspendLayout();
            // 
            // txtFiltro
            // 
            txtFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            txtFiltro.FormattingEnabled = true;
            txtFiltro.Items.AddRange(new object[] { "NOME", "CODIGO", "CPF", "DATANASCIMENTO", "IDADE", "CIDADE", "SEXO" });
            txtFiltro.Location = new Point(12, 31);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(121, 23);
            txtFiltro.TabIndex = 0;
            txtFiltro.Tag = "";
            // 
            // txtBuscaPorFiltro
            // 
            txtBuscaPorFiltro.Location = new Point(154, 31);
            txtBuscaPorFiltro.Name = "txtBuscaPorFiltro";
            txtBuscaPorFiltro.Size = new Size(524, 23);
            txtBuscaPorFiltro.TabIndex = 1;
            txtBuscaPorFiltro.KeyPress += txtBuscaPorFiltro_KeyPress;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(701, 31);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(87, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // dgPesquisa
            // 
            dgPesquisa.AllowUserToAddRows = false;
            dgPesquisa.AllowUserToDeleteRows = false;
            dgPesquisa.BackgroundColor = SystemColors.Desktop;
            dgPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPesquisa.Columns.AddRange(new DataGridViewColumn[] { CODIGO, NOME, DATANASCIMENTO, IDADE, CIDADE, SEXO, CPF });
            dgPesquisa.Location = new Point(12, 99);
            dgPesquisa.Name = "dgPesquisa";
            dgPesquisa.ReadOnly = true;
            dgPesquisa.RowTemplate.Height = 25;
            dgPesquisa.Size = new Size(776, 277);
            dgPesquisa.TabIndex = 3;
            // 
            // CODIGO
            // 
            CODIGO.DataPropertyName = "CODIGO";
            CODIGO.HeaderText = "CODIGO";
            CODIGO.Name = "CODIGO";
            CODIGO.ReadOnly = true;
            // 
            // NOME
            // 
            NOME.DataPropertyName = "NOME";
            NOME.HeaderText = "NOME";
            NOME.Name = "NOME";
            NOME.ReadOnly = true;
            // 
            // DATANASCIMENTO
            // 
            DATANASCIMENTO.DataPropertyName = "DATA";
            DATANASCIMENTO.HeaderText = "DATANASCIMENTO";
            DATANASCIMENTO.Name = "DATANASCIMENTO";
            DATANASCIMENTO.ReadOnly = true;
            // 
            // IDADE
            // 
            IDADE.DataPropertyName = "IDADE";
            IDADE.HeaderText = "IDADE";
            IDADE.Name = "IDADE";
            IDADE.ReadOnly = true;
            // 
            // CIDADE
            // 
            CIDADE.DataPropertyName = "CIDADE";
            CIDADE.HeaderText = "CIDADE";
            CIDADE.Name = "CIDADE";
            CIDADE.ReadOnly = true;
            // 
            // SEXO
            // 
            SEXO.DataPropertyName = "SEXO";
            SEXO.HeaderText = "SEXO";
            SEXO.Name = "SEXO";
            SEXO.ReadOnly = true;
            // 
            // CPF
            // 
            CPF.DataPropertyName = "CPF";
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            CPF.ReadOnly = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(28, 382);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 43);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(668, 382);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(91, 43);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FrmPesquisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(btnCancelar);
            Controls.Add(dgPesquisa);
            Controls.Add(btnOk);
            Controls.Add(txtBuscaPorFiltro);
            Controls.Add(txtFiltro);
            Name = "FrmPesquisa";
            Text = "Pesquisa Geral";
            Load += FrmPesquisa_Load;
            ((System.ComponentModel.ISupportInitialize)dgPesquisa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txtFiltro;
        private TextBox txtBuscaPorFiltro;
        private Button btnOk;
        private DataGridView dgPesquisa;
        private Button btnCancelar;
        private Button btnVoltar;
        private DataGridViewTextBoxColumn CODIGO;
        private DataGridViewTextBoxColumn NOME;
        private DataGridViewTextBoxColumn DATANASCIMENTO;
        private DataGridViewTextBoxColumn IDADE;
        private DataGridViewTextBoxColumn CIDADE;
        private DataGridViewTextBoxColumn SEXO;
        private DataGridViewTextBoxColumn CPF;
    }
}