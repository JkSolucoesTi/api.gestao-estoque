using Api.GestaoEstoque.Infra.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.App.Signature
{
    public class FornecedorSignature
    {
        //fornecedor
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string RazaoSocial { get; set; }

        //ramo atividade
        public int IdRamoAtividade { get; set; }

        //endereco
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        //reponsavel
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Email { get; set; }
    }
}
