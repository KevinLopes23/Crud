using Crud_Estagio.code.Apoio;
using Crud_Estagio.code.bll;
using Crud_Estagio.code.dal;
using Crud_Estagio.code.dto;
using System.Data;



namespace Crud_Estagio
{
    public partial class FrmClientes : Form
    {
        private void LimitaCaracteres()
        {
            try
            {
                txtCodigo.MaxLength = 5;
                txtNome.MaxLength = 100;
                txtIdade.MaxLength = 3;
                txtCidade.MaxLength = 50;
                txtCpf.MaxLength = 11;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao limitar o  os caracteres: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotaoExcluir()
        {
            try
            {
                if (dgCliente.CurrentRow != null)
                {
                    int codigoCliente = int.Parse(dgCliente.CurrentRow.Cells["CODIGO"].Value.ToString());

                    DialogResult result = MessageBox.Show("Deseja realmente excluir?", Constantes.NOME_APLICACAO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        ClientesBll bll = new ClientesBll();
                        bool excluido = bll.ExcluirPorCodigo(codigoCliente);

                        if (excluido)
                        {
                            MessageBox.Show("Cliente excluído com sucesso!", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RecarregarGrid();
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado ou não pôde ser excluído.", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Excluir: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpaGrid()
        {
            dgCliente.DataSource = null;
        }

        private void LimpaCampos()
        {
            try
            {
                txtBuscar.Text = string.Empty;
                txtNome.Text = string.Empty;
                txtIdade.Text = string.Empty;
                txtNascimento.Text = string.Empty;
                txtCidade.Text = string.Empty;
                txtRetornaSexo.SelectedIndex = -1;
                txtRetornaSexo.Refresh();
                txtCpf.Text = string.Empty;
                txtCodigo.Text = string.Empty;


                isEditing = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao limpar os campos: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BotaoGravar()
        {

            try
            {
                ChamaId();

                if (!VerificaCamposPreenchidos())
                {
                    return;
                }

                if (VerificaCpfJaCadastrado())
                {
                    return;
                }

                ClientesDto dto = new ClientesDto();
                dto.Codigo = int.Parse(txtCodigo.Text);
                dto.Nome = txtNome.Text;
                dto.DataNascimento = DateTime.Parse(txtNascimento.Text);
                dto.Idade = int.Parse(txtIdade.Text);
                dto.Cidade = txtCidade.Text;
                dto.Sexo = txtRetornaSexo.Text.Substring(0, 1);
                dto.Cpf = long.Parse(txtCpf.Text);

                ClientesBll bll = new ClientesBll();

                Boolean retorno = bll.Salvar(dto);

                if (retorno == true)
                {
                    MessageBox.Show(
                    "Gravado com Sucesso, muito obrigado", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();
                    txtCodigo.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(
                    "Erro ao gravar. Consulte o suporte.", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao gravar os dados: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool VerificaCpfJaCadastrado()
        {
            try
            {
                ClientesBll bll = new ClientesBll();

                if (bll.CpfJaCadastrado(txtCpf.Text))
                {
                    MessageBox.Show("CPF já cadastrado no sistema", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCpf.Focus();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao verificar o CPF: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;

        }



        private bool VerificaCamposPreenchidos()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCpf.Text))
                {
                    MessageBox.Show(
                    "Insira um Cpf valido ", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCpf.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    MessageBox.Show(
                    "Insira um Codigo valido ", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus();
                    return false;

                }

                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    {
                        MessageBox.Show(
                        "Insira um Nome valido ", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNome.Focus();
                        return false;

                    }
                }

                if (txtNascimento.Text == "  /  /")
                {
                    {
                        MessageBox.Show(
                        "Insira uma Data valida ", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNascimento.Focus();
                        return false;
                    }
                }
                if (string.IsNullOrEmpty(txtIdade.Text))
                {
                    MessageBox.Show(
                    "Insira uma Idade valida ", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdade.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtCidade.Text))
                {
                    MessageBox.Show(
                    "Insira uma Cidade valida ", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCidade.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtRetornaSexo.Text))
                {
                    MessageBox.Show("Insira um Sexo valido ", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRetornaSexo.Focus();
                    return false;
                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao verificar os campos: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }



        public void LimitaAceitaInteiros(KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro a limitar apenas Numeros: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Voltar()
        {
            try
            {
                Form1 frmMain = new Form1();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no processo de voltar : " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void ExibeDadosNoGrid(string nome)
        {

            try
            {
                ClientesBll bll = new ClientesBll();

                DataTable tabela = bll.PesquisaClientes(nome);

                dgCliente.AutoGenerateColumns = true;

                // Converte o DataTable para um DataView e o vincula ao DataGrid
                dgCliente.DataSource = tabela.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao exibir os dados no grid: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void PesquisarPorNome()
        {
            try
            {
                ExibeDadosNoGrid(txtBuscar.Text);

                if (dgCliente.Rows.Count == 0)
                {
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                }
                else
                {
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar os dados: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AceitaLetras(KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro a limitar apenas letras: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ChamaId()
        {
            try
            {
                ClientesDal dal = new ClientesDal();
                int novoCodigo = dal.GeraId();
                txtCodigo.Text = novoCodigo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao gerar novo id: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarCliente()
        {
            try
            {
                ClientesDto cliente = new ClientesDto
                {
                    Codigo = int.Parse(txtCodigo.Text),
                    Nome = txtNome.Text,
                    DataNascimento = DateTime.Parse(txtNascimento.Text),
                    Idade = int.Parse(txtIdade.Text),
                    Cidade = txtCidade.Text,
                    Sexo = txtRetornaSexo.Text.Substring(0, 1),
                    Cpf = long.Parse(txtCpf.Text)
                };

                ClientesBll bll = new ClientesBll();
                bool atualizado = bll.Atualizar(cliente);

                if (atualizado)
                {
                    MessageBox.Show("Cliente atualizado com sucesso!", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RecarregarGrid();
                    LimpaCampos();
                    ChamaId(); // Gera um novo ID para o próximo cliente
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar o cliente.", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o cliente: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RecarregarGrid()
        {
            try
            {
                ClientesBll bll = new ClientesBll();
                dgCliente.DataSource = bll.PesquisaClientes(txtBuscar.Text); // Recarrega os dados no grid com base na pesquisa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao recarregar o grid: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void RetornaComboBoxSexo()
        {

            try
            {
                DataTable dt = new DataTable();
                ClientesBll bll = new();
                dt = bll.RetornaSexo();
                txtRetornaSexo.DataSource = dt;
                txtRetornaSexo.DisplayMember = "DESCRICAO";
                txtRetornaSexo.ValueMember = "CODIGO";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao retornar o ComboBox: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void JogaDoGridParaDadosParaEditar()
        {
            if (dgCliente.CurrentRow != null)
            {
                int codigoCliente = Convert.ToInt32(dgCliente.CurrentRow.Cells["CODIGO"].Value);

                ClientesBll bll = new();
                ClientesDto dto = new ClientesDto();
                dto = bll.DadosCliente(codigoCliente);

                int codigo = dto.Codigo;
                string nome = dto.Nome;
                DateTime data = dto.DataNascimento;
                int idade = dto.Idade;
                string cidade = dto.Cidade;
                long cpf = dto.Cpf;
                string sexo = dto.Sexo;

                // Preenche os campos com base no dto
                txtCodigo.Text = codigo.ToString();
                txtNome.Text = nome;
                txtNascimento.Text = dto.DataNascimento.ToString("dd/MM/yyyy");
                txtIdade.Text = idade.ToString();
                txtCidade.Text = cidade;
                txtCpf.Text = cpf.ToString();
                txtRetornaSexo.Text = sexo == "F" ? "Feminino" : "Masculino";

                //// Preenche os campos com os dados da linha selecionada no DataGrid
                //txtCodigo.Text = dgCliente.CurrentRow.Cells["CODIGO"].Value.ToString();
                //txtNome.Text = dgCliente.CurrentRow.Cells["NOME"].Value.ToString();
                //txtNascimento.Text = dgCliente.CurrentRow.Cells["DATA"].Value.ToString();
                //txtIdade.Text = dgCliente.CurrentRow.Cells["IDADE"].Value.ToString();
                //txtCidade.Text = dgCliente.CurrentRow.Cells["CIDADE"].Value.ToString();
                //txtCpf.Text = dgCliente.CurrentRow.Cells["CPF"].Value.ToString();

                //txtSexo.Text = dgCliente.CurrentRow.Cells["SEXO"].Value.ToString() == "F" ? "Feminino" : "Masculino";

                isEditing = true;
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente no grid para alterar.", Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool isEditing = false;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                AtualizarCliente();
            }
            else
            {
                BotaoGravar();
                RecarregarGrid();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            LimitaCaracteres();
        }

        private void txtNascimento_Leave(object sender, EventArgs e)
        {
            Util.ValidaData(txtNascimento);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            LimitaCaracteres();
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
            LimitaCaracteres();
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            LimitaCaracteres();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitaAceitaInteiros(e);
        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitaAceitaInteiros(e);
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            LimitaCaracteres();
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimitaAceitaInteiros(e);
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ExibeDadosNoGrid(string.Empty);
            ChamaId();
            txtCodigo.PasswordChar = '*';
            RetornaComboBoxSexo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            ChamaId();
            RecarregarGrid();
            txtCodigo.PasswordChar = '*';
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            AceitaLetras(e);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarPorNome();
            LimpaCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            BotaoExcluir();
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            txtCodigo.PasswordChar = '\0';
            JogaDoGridParaDadosParaEditar();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PesquisarPorNome();
            }
        }

        private void dgCliente_Click(object sender, EventArgs e)
        {
            if (dgCliente.Rows.Count <= 0)
                return;

            if (txtCodigo.Text != dgCliente[0, dgCliente.CurrentRow.Index].Value.ToString())
                LimpaCampos();
        }
    }
}

