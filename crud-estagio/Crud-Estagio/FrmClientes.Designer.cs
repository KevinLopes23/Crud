namespace Crud_Estagio
{
    partial class FrmClientes
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dgvResultados = new GroupBox();
            btnAlterar = new Button();
            btnPesquisar = new Button();
            dgCliente = new DataGridView();
            txtBuscar = new TextBox();
            btnExcluir = new Button();
            label1 = new Label();
            txtRetornaSexo = new ComboBox();
            groupBox2 = new GroupBox();
            txtCpf = new TextBox();
            label8 = new Label();
            txtNascimento = new MaskedTextBox();
            txtCidade = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtIdade = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            BtnVoltar = new Button();
            dgvResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCliente).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dgvResultados
            // 
            dgvResultados.Controls.Add(btnAlterar);
            dgvResultados.Controls.Add(btnPesquisar);
            dgvResultados.Controls.Add(dgCliente);
            dgvResultados.Controls.Add(txtBuscar);
            dgvResultados.Controls.Add(btnExcluir);
            dgvResultados.Controls.Add(label1);
            dgvResultados.Location = new Point(12, 12);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(1028, 325);
            dgvResultados.TabIndex = 1;
            dgvResultados.TabStop = false;
            dgvResultados.Text = "Pesquisa";
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(147, 247);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(88, 47);
            btnAlterar.TabIndex = 9;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(926, 55);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(96, 23);
            btnPesquisar.TabIndex = 8;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // dgCliente
            // 
            dgCliente.AllowUserToAddRows = false;
            dgCliente.AllowUserToDeleteRows = false;
            dgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCliente.Location = new Point(31, 84);
            dgCliente.Name = "dgCliente";
            dgCliente.ReadOnly = true;
            dgCliente.RowHeadersWidth = 51;
            dgCliente.Size = new Size(989, 157);
            dgCliente.TabIndex = 2;
            dgCliente.Click += dgCliente_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(30, 55);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(890, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(33, 247);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(96, 47);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 37);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtRetornaSexo
            // 
            txtRetornaSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            txtRetornaSexo.FormattingEnabled = true;
            txtRetornaSexo.Location = new Point(42, 674);
            txtRetornaSexo.Name = "txtRetornaSexo";
            txtRetornaSexo.Size = new Size(656, 23);
            txtRetornaSexo.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCpf);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtNascimento);
            groupBox2.Controls.Add(txtCidade);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtIdade);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtNome);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtCodigo);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 343);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1028, 354);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(30, 105);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(293, 23);
            txtCpf.TabIndex = 17;
            txtCpf.TextChanged += txtCpf_TextChanged;
            txtCpf.KeyPress += txtCpf_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 87);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 18;
            label8.Text = "Cpf";
            // 
            // txtNascimento
            // 
            txtNascimento.Location = new Point(33, 193);
            txtNascimento.Mask = "##/##/####";
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(653, 23);
            txtNascimento.TabIndex = 16;
            txtNascimento.Leave += txtNascimento_Leave;
            // 
            // txtCidade
            // 
            txtCidade.CharacterCasing = CharacterCasing.Upper;
            txtCidade.Location = new Point(31, 281);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(655, 23);
            txtCidade.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 307);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 14;
            label7.Text = "Sexo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 263);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 12;
            label6.Text = "Cidade ";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(30, 237);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(656, 23);
            txtIdade.TabIndex = 9;
            txtIdade.KeyPress += txtIdade_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 219);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 10;
            label5.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 175);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 8;
            label4.Text = "Data de Nascimento";
            // 
            // txtNome
            // 
            txtNome.CharacterCasing = CharacterCasing.Upper;
            txtNome.Location = new Point(30, 149);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(656, 23);
            txtNome.TabIndex = 5;
            txtNome.TextChanged += txtNome_TextChanged;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 131);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Nome";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.ActiveBorder;
            txtCodigo.Location = new Point(33, 46);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(290, 23);
            txtCodigo.TabIndex = 4;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 28);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 4;
            label2.Text = "Codigo";
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(280, 703);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(96, 47);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(399, 703);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 47);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(525, 703);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(96, 47);
            BtnVoltar.TabIndex = 7;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 762);
            Controls.Add(txtRetornaSexo);
            Controls.Add(BtnVoltar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox2);
            Controls.Add(dgvResultados);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            dgvResultados.ResumeLayout(false);
            dgvResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCliente).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private GroupBox dgvResultados;
        private Label label1;
        private TextBox txtBuscar;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtIdade;
        private Label label5;
        private Label label4;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtCodigo;
        private Label label2;
        private TextBox txtCidade;
        private Label label7;
        private Button btnGravar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button BtnVoltar;
        private MaskedTextBox txtNascimento;
        private DataGridView dgCliente;
        private Button btnPesquisar;
        private TextBox txtCpf;
        private Label label8;
        private Button btnAlterar;
        private ComboBox txtRetornaSexo;
    }
}