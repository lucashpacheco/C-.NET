using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Crud_2.register
{
    public class Register
    {
        [DisplayName("Id")]
        public int? Id { get; set; }
        [DisplayName("Nome")]
        public string Nome { get; set; }
        [DisplayName("Sobrenome")]
        public string Sobrenome { get; set; }
        [DisplayName("Telefone")]
        public string Telefone { get; set; }
        [DisplayName("Login")]
        public string Login { get; set; }
        [DisplayName("Senha")]
        public string Senha { get; set; }
        
    }
}
