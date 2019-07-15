using DemoDotNetCoreGraphQL.Infra;
using GraphQL.Types;

namespace DemoDotNetCoreGraphQL.API
{
    public class UsuarioType : ObjectGraphType<Usuario>
    {
        public UsuarioType()
        {
            Field(x => x.Id).Description("Id usuário");
            Field(x => x.Idade);
            Field(x => x.Nome);
            Field(x => x.Posts);
        }
    }
}
