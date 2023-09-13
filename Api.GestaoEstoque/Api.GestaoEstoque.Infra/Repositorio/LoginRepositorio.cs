using Api.GestaoEstoque.Infra.Interface;
using Api.GestaoEstoque.Infra.Signature;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Api.GestaoEstoque.Infra.Response;
using Api.GestaoEstoque.Infra.DataBase;
using System.Reflection.PortableExecutable;
using System.Data.Common;

namespace Api.GestaoEstoque.Infra.Repositorio
{
    public class LoginRepositorio : BaseRepositorio, ILoginRepositorio
    {
        public LoginRepositorio(IConfiguration configuration) : base(configuration)
        {            
        }

        public async Task<AutenticacaoResponse> ObterDadosLogin(AutenticacaoSignature autenticacaoSignature)
        {
            var comando = new SqlCommand("P_OBTER_LOGIN", Connection());
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Email", autenticacaoSignature.Email);
            comando.Parameters.AddWithValue("@Senha", autenticacaoSignature.Password);

            using(var reader = await comando.ExecuteReaderAsync())
            {
                if (await reader.ReadAsync())
                {
                    var nome = reader["Email"].ToString();
                    return new AutenticacaoResponse() { Nome = nome };
                }
            }            
        }

    }
}
