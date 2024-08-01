using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.Infra.Entidade
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string IE { get; set; }
        public RamoAtividade RamoAtividade { get; set; }
        public Endereco Endereco { get; set; }
        public Responsavel Responsavel { get; set; }
        public Email Email { get; set; }
    }
}
