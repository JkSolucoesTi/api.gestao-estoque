using Api.GestaoEstoque.App.Result;
using Api.GestaoEstoque.App.Signature;
using Api.GestaoEstoque.Infra.Entidade;
using Api.GestaoEstoque.Infra.Signature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.App.Converter
{
    public static class EstoqueConverter
    {
        public static ProdutoRepositorioSignature ToProdutoSignatureRepositorio(this ProdutoSignature signature)
        {
            return new ProdutoRepositorioSignature
            {
                Id = signature.Id,
                Codigo = signature.Codigo,
                Nome = signature.Nome,
                FornecedorId = signature.FornecedorId,
                Quantidade = signature.Quantidade,
                Compra = signature.Compra
            };
        }

        public static List<ProdutoResult> ToListProdutoResult (this List<Produto> produto)
        {
            var lista = new List<ProdutoResult>();
            produto.ForEach(p => lista.Add(new ProdutoResult() { Id=p.Id, Codigo = p.Codigo , Nome = p.Nome, Quantidade = p.Quantidade,Compra = p.Compra }));
            return lista;

        }

        public static ProdutoResult ToProdutoResult(this Produto produto)
        {
            return new ProdutoResult()
            {
                Id = produto.Id,
                Codigo = produto.Codigo,
                Nome = produto.Nome,
                Quantidade = produto.Quantidade,
                Compra = produto.Compra,
                FornecedorId = produto.FornecedorId
            };
        }

    }
}
