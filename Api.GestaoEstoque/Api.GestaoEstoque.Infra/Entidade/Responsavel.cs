using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.Infra.Entidade
{
    public class Responsavel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Email { get; set; }
    }
}
