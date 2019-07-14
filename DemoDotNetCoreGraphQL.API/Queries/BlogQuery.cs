using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDotNetCoreGraphQL.API
{
    public class BlogQuery : ObjectGraphType
    {
        public BlogQuery()
        {
            Field<ListGraphType<UsuarioType>>("usarios",
                arguments: new QueryArguments(new List<QueryArgument>
                {
                    new QueryArgument<IdGraphType>{Name="id"}
                }),
                resolve: contexto =>
                {
                    //TODO: usar aplicacao para obter dados
                    return new List<UsuarioType>();
                }
                );
        }
    }
}
