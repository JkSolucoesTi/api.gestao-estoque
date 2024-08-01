using Api.GestaoEstoque.App.Interface;
using Api.GestaoEstoque.App.Signature;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Api.GestaoEstoque.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueController : ControllerBase
    {
        private readonly IEstoqueApp _estoqueApp;

        public EstoqueController(IEstoqueApp estoqueApp)
        {
            _estoqueApp = estoqueApp;
        }

        [HttpPost]
        [Route("IncluirProduto")]
        public async Task<IStatusCodeActionResult> IncluirProduto(ProdutoSignature signature)
        {
            var resultado = await _estoqueApp.Incluir(signature);

            if (resultado > 0) return Ok(true);
            else return BadRequest(false);

        }

        [HttpGet]
        [Route("ObterProdutos")]
        public async Task<IActionResult> ObterProdutos()
        {
            var lista = await _estoqueApp.ObterProduto();
            return Ok(lista);
        }

        [HttpGet]
        [Route("ObterProdutoPorId")]
        public async Task<IActionResult> ObterProdutoPorId(int produtoId)
        {
            var produto = await _estoqueApp.ObterProdutoPorId(produtoId);
            return Ok(produto);
        }

        [HttpPost]
        [Route("AtualizarProduto")]
        public async Task<IStatusCodeActionResult> AtualizarProduto(ProdutoSignature signature)
        {
            var resultado = await _estoqueApp.AtualizarProduto(signature);
            if (resultado > 0) return Ok(true);
            else return BadRequest(false);
        }

        [HttpDelete]
        [Route("ExcluirProduto")]
        public async Task<IStatusCodeActionResult> ExcluirProduto([FromQuery]int produtoId)
        {
            var resultado = await _estoqueApp.ExcluirProduto(produtoId);
            if (resultado > 0) return Ok(true);
            else return BadRequest(false);
        }


    }
}
