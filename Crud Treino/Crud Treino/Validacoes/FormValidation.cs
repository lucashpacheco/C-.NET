using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Treino.Validacoes
{
    public static class FormValidation
    {
        public static bool ValidaCadastro(List<TextBox> textBox)
        {
            var isValid = false;

            foreach(var t in textBox)
            {
                if (!string.IsNullOrEmpty(t.Text))
                {
                    isValid = true;
                }
                else
                {
                    t.BackColor = Color.FromArgb(255, 235, 205);
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}
