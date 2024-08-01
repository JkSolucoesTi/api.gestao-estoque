using Api.GestaoEstoque.App.Signature;
using Api.GestaoEstoque.App.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.GestaoEstoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {

        private readonly IAutenticacaoApp _autenticaocaoApp;

        public AutenticacaoController(IAutenticacaoApp autenticacaoApp)
        {
            _autenticaocaoApp = autenticacaoApp;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginSignature loginSignature)
        {
            var login = await _autenticaocaoApp.Autenticar(loginSignature);
            return Ok(login);
        }

    }
}
