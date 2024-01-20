using Api.GestaoEstoque.App.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.GestaoEstoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RamoAtividadeController : ControllerBase
    {
        private readonly IRamoAtividadeApp _ramoAtividadeApp;

        public RamoAtividadeController(IRamoAtividadeApp ramoAtividadeApp)
        {
            _ramoAtividadeApp = ramoAtividadeApp;
        }

        [HttpGet]
        [Route("ObterRamoAtividade")]
        public async Task<IActionResult> ObterRamoAtividadeAsync()
        {
           var lista = await _ramoAtividadeApp.ObterListaRamoAtividade();
           return Ok(lista);
        }


    }
}
