using Api.GestaoEstoque.App.Result;
using Api.GestaoEstoque.App.Signature;
using Api.GestaoEstoque.Infra.Entidade;

namespace Api.GestaoEstoque.App.Interface
{
    public interface IEstoqueApp
    {
        Task<int> Incluir(ProdutoSignature signature);

        Task<List<ProdutoResult>> ObterProduto();

        Task<ProdutoResult> ObterProdutoPorId(int produtoId);

        Task<int> AtualizarProduto(ProdutoSignature signature);

        Task<int> ExcluirProduto(int produtoId);
    }
}
