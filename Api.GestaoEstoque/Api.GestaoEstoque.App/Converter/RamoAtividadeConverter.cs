using Api.GestaoEstoque.App.Result;
using Api.GestaoEstoque.Infra.Entidade;

namespace Api.GestaoEstoque.App.Converter
{
    public static class RamoAtividadeConverter
    {
        public static List<RamoAtividadeResult> ToRamoAtividadeResult(this List<RamoAtividade> ramoAtividade)
        {
            var lista = new List<RamoAtividadeResult>();
            ramoAtividade.ForEach(ramo => lista.Add(new RamoAtividadeResult() { Id = ramo.Id, Nome = ramo.Nome }));
            return lista;
        }
    }
}
