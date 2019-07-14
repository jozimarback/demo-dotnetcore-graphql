using DemoDotNetCoreGraphQL.Infra;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNetCoreGraphQL.API
{
    public class UsuarioType : ObjectGraphType<Usuario>
    {
        public UsuarioType()
        {
            Field(x => x.Id);
            Field(x => x.Idade);
            Field(x => x.Nome);
            Field(x => x.Posts);
        }
    }
}
