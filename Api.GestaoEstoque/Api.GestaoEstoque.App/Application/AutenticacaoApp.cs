using Api.GestaoEstoque.App.Interface;
using Api.GestaoEstoque.Infra.Interface;
using Api.GestaoEstoque.Infra.Signature;

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
            _loginRepositorio.ObterDadosLogin(new AutenticacaoSignature() { Email="",Password=""});
        }
    }
}
