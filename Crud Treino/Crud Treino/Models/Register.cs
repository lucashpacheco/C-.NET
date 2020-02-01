using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Treino.Models
{
    public class Register
    {
        [DisplayName("ID")]
        public int? Id { get; set; }
        [DisplayName("Nome")]
        public string Nome { get; set; }
        [DisplayName("Apelido")]
        public string Apelido { get; set; }
        [DisplayName("Login")]
        public string Login { get; set; }
        [DisplayName("Senha")]
        public string Senha { get; set; }
        [DisplayName("Obs")]
        public string Obs { get; set; }
    }
}
