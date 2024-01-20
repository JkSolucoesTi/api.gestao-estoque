using Api.GestaoEstoque.App.Converter;
using Api.GestaoEstoque.App.Interface;
using Api.GestaoEstoque.App.Result;
using Api.GestaoEstoque.Infra.Interface;


namespace Api.GestaoEstoque.App.Application
{
    public class RamoAtividadeApp : IRamoAtividadeApp
    {
        private readonly IRamoAtividadeRepositorio _ramoAtividadeRepositorio;

        public RamoAtividadeApp(IRamoAtividadeRepositorio ramoAtividadeRepositorio)
        {
            _ramoAtividadeRepositorio = ramoAtividadeRepositorio;
        }

        public async Task<List<RamoAtividadeResult>> ObterListaRamoAtividade()
        {
            var resultado = await _ramoAtividadeRepositorio.ObterRamoAtividade();
           return RamoAtividadeConverter.ToRamoAtividadeResult(resultado);           
        }
    }
}
