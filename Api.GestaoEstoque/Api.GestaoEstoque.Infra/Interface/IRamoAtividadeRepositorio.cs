using Api.GestaoEstoque.Infra.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.Infra.Interface
{
    public interface IRamoAtividadeRepositorio
    {
        Task<List<RamoAtividade>> ObterRamoAtividade();
    }
}
