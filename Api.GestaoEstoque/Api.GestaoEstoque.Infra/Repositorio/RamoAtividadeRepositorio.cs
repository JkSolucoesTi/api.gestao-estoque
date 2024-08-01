using Api.GestaoEstoque.Infra.Interface;
using Api.GestaoEstoque.Infra.Response;
using Api.GestaoEstoque.Infra.Signature;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.GestaoEstoque.Infra.Entidade;

namespace Api.GestaoEstoque.Infra.Repositorio
{
    public class RamoAtividadeRepositorio : BaseRepositorio , IRamoAtividadeRepositorio
    {
        public RamoAtividadeRepositorio(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<List<RamoAtividade>> ObterRamoAtividade()
        {
            var listaRamoAtividade = new List<RamoAtividade>();

            var comando = new SqlCommand("P_OBTER_RAMO_ATIVIDADE", Connection());
            comando.CommandType = CommandType.StoredProcedure;

            using (var reader = await comando.ExecuteReaderAsync())
            {

                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        var ramo = new RamoAtividade();
                        ramo.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        ramo.Nome = reader.GetString(reader.GetOrdinal("Nome"));
                        listaRamoAtividade.Add(ramo);
                    }
                }
            }
            return listaRamoAtividade;
        }
    }
}
