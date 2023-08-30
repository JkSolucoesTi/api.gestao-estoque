using Api.GestaoEstoque.App.Application;
using Api.GestaoEstoque.App.Interface;
using Api.GestaoEstoque.Infra.Interface;
using Api.GestaoEstoque.Infra.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.GestaoEstoque.Bootstrap
{
    public static class InjectionDependency
    {
        public static void Injection(IServiceCollection service)
        {
            /*Injeção de Dependencia - Application*/
            service.AddScoped<IAutenticacaoApp, AutenticacaoApp>();

            /*Injeção de Dependencia - Repositorio*/
            service.AddScoped<ILoginRepositorio, LoginRepositorio>();
        }
    }
}
