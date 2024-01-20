using Api.GestaoEstoque.App.Interface;
using Api.GestaoEstoque.App.Signature;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.GestaoEstoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {

        private readonly IFornecedorApp _fornecedorApp;

        public FornecedorController(IFornecedorApp fornecedorApp)
        {
            _fornecedorApp = fornecedorApp;
        }

        [HttpPost]
        [Route("IncluirFornecedor")]
        public async Task<IActionResult> IncluirFornecedor(FornecedorSignature signature)
        {
            var resultado = await _fornecedorApp.Adicionar(signature);

            if (resultado > 0) return Ok();
            else return BadRequest();

        }

        [HttpGet]
        [Route("ObterFornecedores")]
        public async Task<IActionResult> ObterFornecedores()
        {
            var lista = await _fornecedorApp.ObterFornecedores();
            return Ok(lista);
        }

        [HttpGet]
        [Route("ObterFornecedorPorId")]
        public async Task<IActionResult> ObterFornecedorPorId(int fornecedorId)
        {
            var fornecedor = await _fornecedorApp.ObterFornecedoresPorId(fornecedorId);
            return Ok(fornecedor);
        }

        [HttpPost]
        [Route("AtualizarFornecedor")]
        public async Task<IActionResult> AtualizarFornecedor(FornecedorSignature signature)
        {
            var resultado = await _fornecedorApp.AtualizarFornecedor(signature);

            if (resultado > 0) return Ok();
            else return BadRequest();

        }


    }
}
