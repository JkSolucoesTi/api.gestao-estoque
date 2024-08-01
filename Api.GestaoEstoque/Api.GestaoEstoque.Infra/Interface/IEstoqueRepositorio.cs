using Api.GestaoEstoque.Infra.Entidade;
using Api.GestaoEstoque.Infra.Signature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.Infra.Interface
{
    public interface IEstoqueRepositorio
    {
        public Task<int> IncluirProduto(ProdutoRepositorioSignature signature);

        public Task<List<Produto>> ObterProdutos();

        public Task<Produto> ObterProdutoPorId(int produtoId);

        public Task<Produto> ObterProdutoPorCodigo(int codigoProduto);

        public Task<int> AtualizarProduto(ProdutoRepositorioSignature signature);

        public Task<int> ExcluirProduto(int produtoId);
    }
}
