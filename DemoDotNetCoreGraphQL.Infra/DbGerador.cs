using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoDotNetCoreGraphQL.Infra
{
    public class DbGerador
    {
        /// <summary>
        /// Inicia banco em memória
        /// </summary>
        public static void Iniciar(IServiceProvider serviceProvider)
        {
            using(var contexto = new BlogContext(serviceProvider.GetRequiredService<DbContextOptions<BlogContext>>()))
            {
                if (contexto.Usuarios.Any())
                {
                    return;   // Dados ja foram providos
                }

                contexto.Usuarios.AddRange(
                    new Usuario()
                    {
                        Id = 1,
                        Email = "maria@teste.com.br",
                        Idade = 18,
                        Nome = "Maria Tcha Tcha Tcha"
                    },
                    new Usuario()
                    {
                        Id = 2,
                        Email = "joao@teste.com.br",
                        Idade = 31,
                        Nome = "Joao dos Venenos"
                    },
                    new Usuario()
                    {
                        Id = 3,
                        Email = "tereza.spk@teste.com.br",
                        Idade = 31,
                        Nome = "Tereza D'avila"
                    }
                    );
            }
        }
    }
}
