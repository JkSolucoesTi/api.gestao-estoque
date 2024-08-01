using Api.GestaoEstoque.App.Result;
using Api.GestaoEstoque.App.Signature;

namespace Api.GestaoEstoque.App.Interface
{
    public interface IAutenticacaoApp
    {
        public Task<LoginResult> Autenticar(LoginSignature loginSignature);
    }
}
