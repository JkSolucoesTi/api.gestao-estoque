using Api.GestaoEstoque.App.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.App.Interface
{
    public interface IRamoAtividadeApp
    {
        Task<List<RamoAtividadeResult>> ObterListaRamoAtividade();
    }
}
