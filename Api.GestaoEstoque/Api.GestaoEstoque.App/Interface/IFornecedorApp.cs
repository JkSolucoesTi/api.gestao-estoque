using Api.GestaoEstoque.App.Result;
using Api.GestaoEstoque.App.Signature;

namespace Api.GestaoEstoque.App.Interface
{
    public interface IFornecedorApp
    {
        Task<int> Adicionar(FornecedorSignature signature);

        Task<List<FornecedorResult>> ObterFornecedores();

        Task<FornecedorResult> ObterFornecedoresPorId(int fornecedorId);

        Task<int> AtualizarFornecedor(FornecedorSignature signature);
    }
}
