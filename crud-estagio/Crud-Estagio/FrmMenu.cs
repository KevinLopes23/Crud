using Crud_Estagio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Estagio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnClientes_Click(object sender, EventArgs e)
        {
            Visible = false;

            FrmClientes Clientes = new FrmClientes();
            Form1 FrmMenu = new Form1();
           
            try
            {
                Clientes.ShowDialog();
                Visible = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu  um erro ao abrir a tela de clientes" + erro.Message);
            }
            finally
            {
                if (Clientes != null)
                    Clientes.Dispose();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            FrmPesquisa pesquisa = new FrmPesquisa();
            pesquisa.ShowDialog();
        }
    }




}
