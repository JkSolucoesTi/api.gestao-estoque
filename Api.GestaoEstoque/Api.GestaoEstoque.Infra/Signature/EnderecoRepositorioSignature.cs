using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.Infra.Signature
{
    public class EnderecoRepositorioSignature
    {
        public string Cep {get;set;}
        public string Rua {get;set;}
        public string Bairro {get;set;}
        public string Cidade {get;set;}
        public string Estado {get;set;}
    }
}
