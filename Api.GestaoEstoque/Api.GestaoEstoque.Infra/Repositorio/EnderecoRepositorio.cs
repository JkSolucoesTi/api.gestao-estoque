using Api.GestaoEstoque.Infra.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.Infra.Repositorio
{
    public class EnderecoRepositorio : BaseRepositorio , IEnderecoRepositorio
    {
        public EnderecoRepositorio(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
