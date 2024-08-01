using Api.GestaoEstoque.App.Result;
using Api.GestaoEstoque.App.Signature;
using Api.GestaoEstoque.Infra.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.App.Converter
{
    public static class LoginConverter
    {
        public static LoginResult ToLoginResultError(this LoginSignature reponse)
        {
            return new LoginResult() { Nome = "", Success = false };
        }


        public static LoginResult ToLoginResultSuccess(this AutenticacaoResponse reponse)
        {
            return new LoginResult() { Nome = reponse.Nome, Success = true };
        }
    }
}
