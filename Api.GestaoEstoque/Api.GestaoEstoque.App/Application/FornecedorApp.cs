using Api.GestaoEstoque.App.Converter;
using Api.GestaoEstoque.App.Interface;
using Api.GestaoEstoque.App.Result;
using Api.GestaoEstoque.App.Signature;
using Api.GestaoEstoque.Infra.Interface;
using Api.GestaoEstoque.Infra.Signature;
using System.Transactions;

namespace Api.GestaoEstoque.App.Application
{

    public class FornecedorApp : IFornecedorApp
    {
        private readonly IFornecedorRepositorio _fornecedorRepositorio;


        public FornecedorApp(IFornecedorRepositorio fornecedorRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
        }

        public async Task<int> Adicionar(FornecedorSignature signature)
        {
            return await _fornecedorRepositorio.IncluirFornecedor(FornecedorConverter.ToFornecedorRespositorio(signature));
        }

        public async Task<int> AtualizarFornecedor(FornecedorSignature signature)
        {
            var fornecedor = await _fornecedorRepositorio.ObterFornecedorPorId(signature.Id);

            if(fornecedor.Id == signature.Id)
            {
                var retorno = await _fornecedorRepositorio.AtualizarFornecedor
                    (
                        FornecedorConverter.ToFornecedorRespositorio(signature)
                    );
                return retorno;
            }

            return 0;
        }

        public async Task<List<FornecedorResult>> ObterFornecedores()
        {
            var lista = await _fornecedorRepositorio.ObterFornecedor();
            return FornecedorConverter.ToListFornecedorResult(lista);
        }

        public async Task<FornecedorResult> ObterFornecedoresPorId(int fornecedorId)
        {
            var fornecedor = await _fornecedorRepositorio.ObterFornecedorPorId(fornecedorId);
            return FornecedorConverter.ToFornecedorResult(fornecedor);
        }
    }
}
