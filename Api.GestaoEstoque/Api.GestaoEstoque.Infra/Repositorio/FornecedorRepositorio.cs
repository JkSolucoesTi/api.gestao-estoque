using Api.GestaoEstoque.Infra.Entidade;
using Api.GestaoEstoque.Infra.Interface;
using Api.GestaoEstoque.Infra.Signature;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Api.GestaoEstoque.Infra.Repositorio
{
    public class FornecedorRepositorio : BaseRepositorio , IFornecedorRepositorio
    {

        public FornecedorRepositorio(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<int> AtualizarFornecedor(FornecedorRepositorioSignature signature)
        {
            try
            {
                var comando = new SqlCommand("P_ATUALIZAR_FORNECEDOR", Connection());
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Id", signature.Id);
                comando.Parameters.AddWithValue("@Cnpj", signature.Cnpj);
                comando.Parameters.AddWithValue("@InscricaoEstadual", signature.InscricaoEstadual);
                comando.Parameters.AddWithValue("@RazaoSocial", signature.RazaoSocial);
                comando.Parameters.AddWithValue("@IdRamoAtividade", signature.IdRamoAtividade);
                comando.Parameters.AddWithValue("@Cep", signature.Cep);
                comando.Parameters.AddWithValue("@Rua", signature.Rua);
                comando.Parameters.AddWithValue("@Bairro", signature.Bairro);
                comando.Parameters.AddWithValue("@Cidade", signature.Cidade);
                comando.Parameters.AddWithValue("@Estado", signature.Estado);
                comando.Parameters.AddWithValue("@Nome", signature.Nome);
                comando.Parameters.AddWithValue("@Funcao", signature.Funcao);
                comando.Parameters.AddWithValue("@Email", signature.Email);

                var retorno = await comando.ExecuteNonQueryAsync();
                return retorno;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        public async Task<int> IncluirFornecedor(FornecedorRepositorioSignature signature)
        {
                try
                {
                    var comando = new SqlCommand("P_INSERIR_FORNECEDOR", Connection());
                        comando.CommandType = CommandType.StoredProcedure;

                        comando.Parameters.AddWithValue("@Cnpj", signature.Cnpj);
                        comando.Parameters.AddWithValue("@InscricaoEstadual", signature.InscricaoEstadual);
                        comando.Parameters.AddWithValue("@RazaoSocial", signature.RazaoSocial);
                        comando.Parameters.AddWithValue("@IdRamoAtividade", signature.IdRamoAtividade);
                        comando.Parameters.AddWithValue("@Cep", signature.Cep);
                        comando.Parameters.AddWithValue("@Rua", signature.Rua);
                        comando.Parameters.AddWithValue("@Bairro", signature.Bairro);
                        comando.Parameters.AddWithValue("@Cidade", signature.Cidade);
                        comando.Parameters.AddWithValue("@Estado", signature.Estado);
                        comando.Parameters.AddWithValue("@Nome", signature.Nome);
                        comando.Parameters.AddWithValue("@Funcao", signature.Funcao);
                        comando.Parameters.AddWithValue("@Email", signature.Email);

                        var retorno = await comando.ExecuteNonQueryAsync();
                        return retorno;
                }
                catch (Exception ex)
                {                    
                    throw new NotImplementedException();
                }       
        }

        public async Task<List<Fornecedor>> ObterFornecedor()
        {
            var listaFornecedor = new List<Fornecedor>();

            var comando = new SqlCommand("P_OBTER_FORNECEDOR", Connection());
            comando.CommandType = CommandType.StoredProcedure;

            using (var reader = await comando.ExecuteReaderAsync())
            {

                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        var fornecedor = new Fornecedor();
                        fornecedor.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        fornecedor.Cnpj = reader.GetString(reader.GetOrdinal("Cnpj"));
                        fornecedor.IE = reader.GetString(reader.GetOrdinal("IE"));
                        fornecedor.RazaoSocial = reader.GetString(reader.GetOrdinal("RazaoSocial"));
                        listaFornecedor.Add(fornecedor);
                    }
                }
            }
            return listaFornecedor;
        }

        public async Task<Fornecedor> ObterFornecedorPorId(int fornecedorId)
        {
            var fornecedor = new Fornecedor();

            var comando = new SqlCommand("P_OBTER_FORNECEDOR_POR_ID", Connection());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@FornecedorId", fornecedorId);

            using (var reader = await comando.ExecuteReaderAsync())
            {
                if (await reader.ReadAsync())
                {
                    fornecedor.Id = reader.GetInt32(reader.GetOrdinal("IdFornecedor"));
                    fornecedor.RazaoSocial = reader.GetString(reader.GetOrdinal("RazaoSocial"));
                    fornecedor.Cnpj = reader.GetString(reader.GetOrdinal("Cnpj"));
                    fornecedor.IE = reader.GetString(reader.GetOrdinal("IE"));
                    fornecedor.Cnpj = reader.GetString(reader.GetOrdinal("Cnpj"));
                    fornecedor.RamoAtividade = new RamoAtividade
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("IdRamoAtividade")),
                        Nome = reader.GetString(reader.GetOrdinal("Nome")),
                    };

                    fornecedor.Endereco = new Endereco
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("IdEndereco")),
                        Cep = reader.GetString(reader.GetOrdinal("Cep")),
                        Rua = reader.GetString(reader.GetOrdinal("Rua")),
                        Bairro = reader.GetString(reader.GetOrdinal("Bairro")),
                        Cidade = reader.GetString(reader.GetOrdinal("Cidade")),
                        Estado = reader.GetString(reader.GetOrdinal("Estado")),
                    };

                    fornecedor.Responsavel = new Responsavel
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("IdResponsavel")), 
                        Nome = reader.GetString(reader.GetOrdinal("NomeResponsavel")),
                        Funcao = reader.GetString(reader.GetOrdinal("Funcao")),
                        Email = reader.GetString(reader.GetOrdinal("EmailResponsavel"))
                    };

                    fornecedor.Email = new Email
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("IdEmail")),
                        EnderecoEmail = reader.GetString(reader.GetOrdinal("Email"))
                    };
                }
            }
            return fornecedor;
        }
    }
}
