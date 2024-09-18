using Crud_Estagio.code.Apoio;
using Crud_Estagio.code.bll;



namespace Crud_Estagio
{
    public partial class FrmPesquisa : Form
    {
        public FrmPesquisa()
        {
            InitializeComponent();
        }






        private bool VerificaCamposPreenchidos()
        {
            try
            {
                if (string.IsNullOrEmpty(txtBuscaPorFiltro.Text))
                {
                    MessageBox.Show(
                        "Insira o filtro válido",
                        Constantes.NOME_APLICACAO,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                        );

                    txtBuscaPorFiltro.Focus();
                    return false;
                }

                if (txtFiltro.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Insira um filtro válido",
                        Constantes.NOME_APLICACAO,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );

                    txtFiltro.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtFiltro.SelectedItem.ToString()))
                {
                    MessageBox.Show(
                        "Insira um filtro válido",
                        Constantes.NOME_APLICACAO,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation
                    );

                    txtFiltro.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao verificar os campos: {ex.Message}");
                return false;
            }
        }








        private void DisparaBuscaPorFiltro()
        {
            try
            {
                //LimpaCampos()

                if (!VerificaCamposPreenchidos())
                {
                    return; // Se a verificação falhar, interrompe a execução.
                }
                else
                {
                    ClientesBll bll = new ClientesBll();
                    string? filtro = txtFiltro.SelectedItem.ToString();
                    string valor = txtBuscaPorFiltro.Text;

                    dgPesquisa.DataSource = bll.ObterPorFiltro(filtro, valor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao disparar filtro: " + ex.Message, Constantes.NOME_APLICACAO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LimpaCampos()
        {
            txtBuscaPorFiltro.Text = string.Empty;
            dgPesquisa.DataSource = null;
            txtFiltro.SelectedIndex = -1;
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            DisparaBuscaPorFiltro();
        }


        private void txtBuscaPorFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk_Click(sender, e);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 FrmMenu = new Form1();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void FrmPesquisa_Load(object sender, EventArgs e)
        {
            //txtFiltro.SelectedIndex = 0;
            txtFiltro.Text = "NOME";
        }

        private void txtBuscaPorFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }




    }
}
