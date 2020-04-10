using DemoDotNetCoreGraphQL.Infra;
using GraphQL.Types;

namespace DemoDotNetCoreGraphQL.API
{
    public class UsuarioType : ObjectGraphType<Usuario>
    {
        public UsuarioType()
        {
            Name = "Usuario";
            Field(x => x.Id,type:typeof(IdGraphType)).Description("Id usuário");
            Field(x => x.Idade).Description("Idade do usuário");
            Field(x => x.Nome).Description("Nome do usuário");
            Field(x => x.DataCriacao, type: typeof(DateTimeGraphType)).Description("Data criação usuário");
            Field(x => x.DataAlteracao, type:typeof(DateTimeGraphType)).Description("Data alteração usuário");
            //Field(x => x.Posts).Description("Posts relacionados");
        }
    }
}
