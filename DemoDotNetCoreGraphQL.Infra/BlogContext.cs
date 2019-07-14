using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDotNetCoreGraphQL.Infra
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> opcoes):base(opcoes)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
