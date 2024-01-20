using Api.GestaoEstoque.App.Converter;
using Api.GestaoEstoque.App.Interface;
using Api.GestaoEstoque.App.Result;
using Api.GestaoEstoque.App.Signature;
using Api.GestaoEstoque.Infra.Entidade;
using Api.GestaoEstoque.Infra.Interface;
using Api.GestaoEstoque.Infra.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.App.Application
{
    public class EstoqueApp : IEstoqueApp
    {

        private readonly IEstoqueRepositorio _estoqueRepositorio;

        public EstoqueApp(IEstoqueRepositorio estoqueRepositorio)
        {
            _estoqueRepositorio = estoqueRepositorio;
        }

        public async Task<int> Incluir(ProdutoSignature signature)
        {
            return await _estoqueRepositorio.IncluirProduto(EstoqueConverter.ToProdutoSignatureRepositorio(signature));
        }

        public async Task<List<ProdutoResult>> ObterProduto()
        {
            var lista = await _estoqueRepositorio.ObterProdutos();
            return lista.ToListProdutoResult();
        }

        public async Task<ProdutoResult> ObterProdutoPorId(int produtoId)
        {
            var produto = await _estoqueRepositorio.ObterProdutoPorId(produtoId);
            return produto.ToProdutoResult();
        }

        public async Task<int> AtualizarProduto(ProdutoSignature signature)
        {
            var produto = await _estoqueRepositorio.ObterProdutoPorId(signature.Id);

            if(produto.Id == signature.Id)
            {
               return await _estoqueRepositorio.AtualizarProduto(EstoqueConverter.ToProdutoSignatureRepositorio(signature));
            }

            return 0;
        }

        public async Task<int> ExcluirProduto(int produtoId)
        {
            var produto = await _estoqueRepositorio.ObterProdutoPorId(produtoId);

            if(produto.Id == produtoId)
            {
                var retorno = await _estoqueRepositorio.ExcluirProduto(produto.Id);
                return retorno;
            }

            return 0;
        }
    }
}
