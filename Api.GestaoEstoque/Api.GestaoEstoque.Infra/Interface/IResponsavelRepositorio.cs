using Api.GestaoEstoque.Infra.Signature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.Infra.Interface
{
    public interface IResponsavelRepositorio
    {
        Task<int> Inserir(ResponsavelRepositorioSignature responsavelRepositorioSignature);
    }
}
