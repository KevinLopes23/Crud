using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Estagio.code.Apoio
{
    public class Util
    {

        public static void ValidaData(MaskedTextBox campo)
        {
            try
            {
                if (campo.Text == "  /  /")
                    return;

                DateTime data = Convert.ToDateTime(campo.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Data invalida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                campo.Text = string.Empty;
                campo.Focus();
            }
        }





    }
}
