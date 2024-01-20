using Api.GestaoEstoque.App.Result;
using Api.GestaoEstoque.App.Signature;
using Api.GestaoEstoque.Infra.Entidade;
using Api.GestaoEstoque.Infra.Signature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.App.Converter
{
    public static class FornecedorConverter
    {
        public static FornecedorRepositorioSignature ToFornecedorRespositorio (this FornecedorSignature signature)
        {
            return new FornecedorRepositorioSignature
            {
                Id = signature.Id,
                Cnpj = signature.Cnpj,
                InscricaoEstadual = signature.InscricaoEstadual,
                RazaoSocial = signature.RazaoSocial,
                IdRamoAtividade = signature.IdRamoAtividade,
                Cep = signature.Cep,
                Rua = signature.Rua,
                Bairro = signature.Bairro,
                Cidade = signature.Cidade,
                Estado = signature.Estado,
                Nome = signature.Nome,
                Funcao = signature.Funcao,
                Email = signature.Email,
            };
        }

        public static List<FornecedorResult> ToListFornecedorResult(this List<Fornecedor> fornecedor)
        {
            var lista = new List<FornecedorResult>();
            fornecedor.ForEach(f => lista.Add(new FornecedorResult() {  Id = f.Id , IE = f.IE , Cnpj = f.Cnpj , RazaoSocial = f.RazaoSocial }));
            return lista;
        }

        public static FornecedorResult ToFornecedorResult(this Fornecedor fornecedor)
        {
            return new FornecedorResult()
            {
                Id = fornecedor.Id,
                IE = fornecedor.IE,
                Cnpj = fornecedor.Cnpj,
                RazaoSocial = fornecedor.RazaoSocial,
                IdRamoAtividade = fornecedor.RamoAtividade.Id,
                Rua = fornecedor.Endereco.Rua,
                Cep = fornecedor.Endereco.Cep,
                Bairro = fornecedor.Endereco.Bairro,
                Cidade = fornecedor.Endereco.Cidade,
                Estado = fornecedor.Endereco.Estado,
                Nome = fornecedor.Responsavel.Nome,
                Funcao = fornecedor.Responsavel.Funcao,
                Email = fornecedor.Responsavel.Email
            };            
        }

    }
}
