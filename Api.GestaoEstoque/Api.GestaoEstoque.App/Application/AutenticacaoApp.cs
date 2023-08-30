using Api.GestaoEstoque.App.Interface;
using Api.GestaoEstoque.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.App.Application
{

    public class AutenticacaoApp : IAutenticacaoApp
    {
        private readonly ILoginRepositorio _loginRepositorio;

        public AutenticacaoApp(ILoginRepositorio loginRepositorio)
        {
            _loginRepositorio = loginRepositorio;
        }

        public void Autenticar()
        {
            _loginRepositorio.ObterDadosLogin();
        }
    }
}
