using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.App.Result
{
    public class FornecedorResult
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj {get;set;}
        public string IE { get; set; }
        public int IdRamoAtividade { get; set; }
        public string Rua { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Email { get; set; }

    }
}
