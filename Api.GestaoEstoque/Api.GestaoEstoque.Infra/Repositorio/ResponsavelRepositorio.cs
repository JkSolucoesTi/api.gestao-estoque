using Api.GestaoEstoque.Infra.Interface;
using Api.GestaoEstoque.Infra.Signature;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Api.GestaoEstoque.Infra.Repositorio
{
    public class ResponsavelRepositorio : BaseRepositorio , IResponsavelRepositorio
    {
        public ResponsavelRepositorio(IConfiguration configuration) : base(configuration)
        {
        }
            public async Task<int> Inserir(ResponsavelRepositorioSignature responsavelRepositorioSignature)
            {
                try
                {
                    var comando = new SqlCommand("P_INSERIR_REPONSAVEL", Connection());
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Funcao", responsavelRepositorioSignature.Funcao);
                    comando.Parameters.AddWithValue("@Nome", responsavelRepositorioSignature.Nome);

                    var parameterId = new SqlParameter("@ID", SqlDbType.Int);
                    parameterId.Direction = ParameterDirection.Output;
                    comando.Parameters.Add(parameterId);

                    await comando.ExecuteNonQueryAsync();

                    var id = Convert.ToInt32(parameterId.Value);
                    return id;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

        }
    }

