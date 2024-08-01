using Api.GestaoEstoque.Infra.Signature;

namespace Api.GestaoEstoque.Infra.Interface
{
    public interface IEmailRepositorio
    {
        Task<int> Inserir(EmailRepositorioSignature emailRepositorioSignature);
    }
}
