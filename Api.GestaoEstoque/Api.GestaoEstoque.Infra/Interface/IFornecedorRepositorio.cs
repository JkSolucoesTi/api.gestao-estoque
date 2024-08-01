using Api.GestaoEstoque.Infra.Entidade;
using Api.GestaoEstoque.Infra.Signature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.Infra.Interface
{
    public interface IFornecedorRepositorio
    {
        public Task<int> IncluirFornecedor(FornecedorRepositorioSignature signature);

        public Task<List<Fornecedor>> ObterFornecedor();

        public Task<Fornecedor> ObterFornecedorPorId(int fornecedorId);

        public Task<int> AtualizarFornecedor(FornecedorRepositorioSignature signature);

    }
}
