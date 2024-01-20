using Api.GestaoEstoque.App.Converter;
using Api.GestaoEstoque.App.Interface;
using Api.GestaoEstoque.App.Result;
using Api.GestaoEstoque.App.Signature;
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

        public async Task<LoginResult> Autenticar(LoginSignature loginSignature)
        {

            if (string.IsNullOrEmpty(loginSignature.Usuario) 
                || string.IsNullOrEmpty(loginSignature.Senha))
            {
                return LoginConverter.ToLoginResultError(loginSignature);
            }
                              
            var resultado = 
                    await _loginRepositorio.ObterDadosLogin(new AutenticacaoSignature() 
                { Email = loginSignature.Usuario, Password = loginSignature.Senha });

            return LoginConverter.ToLoginResultSuccess(resultado);

        }
    }
}
