using Api.GestaoEstoque.App.Application;
using Api.GestaoEstoque.App.Interface;
using Api.GestaoEstoque.Signature;
using Microsoft.AspNetCore.Http;
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
        public IActionResult Login(LoginSignature loginSignature)
        {
            _autenticaocaoApp.Autenticar();
            return null;
        }

    }
}
