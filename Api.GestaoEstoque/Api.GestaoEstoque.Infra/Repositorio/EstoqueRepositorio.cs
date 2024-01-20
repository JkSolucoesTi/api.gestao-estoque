using Api.GestaoEstoque.Infra.Entidade;
using Api.GestaoEstoque.Infra.Interface;
using Api.GestaoEstoque.Infra.Signature;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Api.GestaoEstoque.Infra.Repositorio
{
    public class EstoqueRepositorio : BaseRepositorio, IEstoqueRepositorio
    {
        public EstoqueRepositorio(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<int> IncluirProduto(ProdutoRepositorioSignature signature)
        {
            try
            {
                var comando = new SqlCommand("P_INSERIR_PRODUTO", Connection());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Codigo", signature.Codigo);
                comando.Parameters.AddWithValue("@Nome", signature.Nome);
                comando.Parameters.AddWithValue("@FornecedorId", signature.FornecedorId);
                comando.Parameters.AddWithValue("@Quantidade", signature.Quantidade);
                comando.Parameters.AddWithValue("@Compra", signature.Compra);

                var retorno = await comando.ExecuteNonQueryAsync();
                return retorno;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public async Task<List<Produto>> ObterProdutos()
        {
            var listaProdutos = new List<Produto>();

            var comando = new SqlCommand("P_OBTER_PRODUTOS", Connection());
            comando.CommandType = CommandType.StoredProcedure;

            using (var reader = await comando.ExecuteReaderAsync())
            {

                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        var produto = new Produto();
                        produto.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        produto.Codigo = reader.GetInt32(reader.GetOrdinal("Codigo"));
                        produto.Nome = reader.GetString(reader.GetOrdinal("Nome"));
                        produto.FornecedorId = reader.GetInt32(reader.GetOrdinal("FornecedorId"));
                        produto.Quantidade = reader.GetInt32(reader.GetOrdinal("Quantidade"));
                        produto.Compra = reader.GetDecimal(reader.GetOrdinal("Compra"));

                        listaProdutos.Add(produto);
                    }
                }
            }
            return listaProdutos;
        }

        public async Task<Produto> ObterProdutoPorId(int produtoId)
        {
            var produto = new Produto();

            var comando = new SqlCommand("P_OBTER_PRODUTO_POR_ID", Connection());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ProdutoId", produtoId);

            using (var reader = await comando.ExecuteReaderAsync())
            {
                if (await reader.ReadAsync())
                {                  
                   produto.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                   produto.Codigo = reader.GetInt32(reader.GetOrdinal("Codigo"));
                   produto.Nome = reader.GetString(reader.GetOrdinal("Nome"));
                   produto.FornecedorId = reader.GetInt32(reader.GetOrdinal("FornecedorId"));
                   produto.Quantidade = reader.GetInt32(reader.GetOrdinal("Quantidade"));
                   produto.Compra = reader.GetDecimal(reader.GetOrdinal("Compra"));                        
                }
            }
            return produto;
        }

        public async Task<Produto> ObterProdutoPorCodigo(int codigoProduto)
        {
            var produto = new Produto();

            var comando = new SqlCommand("P_OBTER_PRODUTO_POR_CODIGO", Connection());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@CodigoProduto", codigoProduto);

            using (var reader = await comando.ExecuteReaderAsync())
            {
                if (await reader.ReadAsync())
                {
                    produto.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    produto.Codigo = reader.GetInt32(reader.GetOrdinal("Codigo"));
                    produto.Nome = reader.GetString(reader.GetOrdinal("Nome"));
                    produto.FornecedorId = reader.GetInt32(reader.GetOrdinal("FornecedorId"));
                    produto.Quantidade = reader.GetInt32(reader.GetOrdinal("Quantidade"));
                    produto.Compra = reader.GetDecimal(reader.GetOrdinal("Compra"));
                }                
            }
            return produto;
        }

        public async Task<int> AtualizarProduto(ProdutoRepositorioSignature signature)
        {
            try
            {
                var comando = new SqlCommand("P_ATUALIZAR_PRODUTO", Connection());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Id", signature.Id);
                comando.Parameters.AddWithValue("@Codigo", signature.Codigo);
                comando.Parameters.AddWithValue("@Nome", signature.Nome);
                comando.Parameters.AddWithValue("@FornecedorId", signature.FornecedorId);
                comando.Parameters.AddWithValue("@Quantidade", signature.Quantidade);
                comando.Parameters.AddWithValue("@Compra", signature.Compra);

                var retorno = await comando.ExecuteNonQueryAsync();
                return retorno;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public async Task<int> ExcluirProduto(int produtoId)
        {
            try
            {
                var comando = new SqlCommand("P_EXCLUIR_PRODUTO", Connection());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@ProdutoId", produtoId);
             
                var retorno = await comando.ExecuteNonQueryAsync();
                return retorno;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}
