using DemoDotNetCoreGraphQL.Infra;
using GraphQL.Types;

namespace DemoDotNetCoreGraphQL.API
{
    public class BlogMutation : ObjectGraphType<object>
    {
        public BlogMutation(UsuarioRepositorio repositorio)
        {
            Name = "Mutation";
            Field<UsuarioType>("criarUsuario",
                arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<UsuarioInputType>> { Name = "usuario" }
                ),
                resolve: context =>
                {
                    var usuario = context.GetArgument<Usuario>("usuario");
                    return repositorio.Adicionar(usuario);
                });
        }
    }
}
