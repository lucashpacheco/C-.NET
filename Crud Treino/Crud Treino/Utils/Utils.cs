using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_Treino.Utils
{
    public static class Utils
    {
        public static void CleanTextBox(List<TextBox> texts)
        {
            texts.ForEach(x => {
                x.Text = "";
            });
        }
    }
}
