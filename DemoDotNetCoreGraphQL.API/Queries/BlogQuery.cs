using DemoDotNetCoreGraphQL.Infra;
using GraphQL.Types;

namespace DemoDotNetCoreGraphQL.API
{
    public class BlogQuery : ObjectGraphType
    {
        public BlogQuery(UsuarioRepositorio repositorio)
        {
            Field<ListGraphType<UsuarioType>>("usarios",
                arguments: new QueryArguments(new QueryArgument[]
                {
                    new QueryArgument<IdGraphType>{Name="id"},
                    new QueryArgument<StringGraphType>{Name="nome"}
                }),
                resolve: contexto =>
                {
                    var filtro = new UsuarioFiltro()
                    {
                        Id = contexto.GetArgument<int>("id"),
                        Nome = contexto.GetArgument<string>("nome"),
                    };
                    //TODO: usar aplicacao para obter dados
                    return repositorio.ObterUsuarios(filtro);
                }
                );
        }
    }
}
