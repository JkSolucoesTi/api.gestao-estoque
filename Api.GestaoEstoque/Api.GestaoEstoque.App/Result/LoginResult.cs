using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.App.Result
{
    public class LoginResult
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Success { get; set; }
    }
}
