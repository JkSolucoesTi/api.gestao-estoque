using Api.GestaoEstoque.Infra.Entidade;
using Api.GestaoEstoque.Infra.Interface;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Api.GestaoEstoque.Infra.Signature;

namespace Api.GestaoEstoque.Infra.Repositorio
{
    public class EmailRepositorio : BaseRepositorio , IEmailRepositorio
    {
        public EmailRepositorio(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<int> Inserir(EmailRepositorioSignature emailRepositorioSignature)
        {
            try
            {
                var comando = new SqlCommand("P_INSERIR_EMAIL", Connection());
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Email", emailRepositorioSignature.Email);

                var parameterId = new SqlParameter("@ID", SqlDbType.Int);
                parameterId.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parameterId);

                await comando.ExecuteNonQueryAsync();

                var id = Convert.ToInt32(parameterId.Value);
                return id;

            }catch(Exception ex)
            {
                throw;
            }
        }
    }
}
