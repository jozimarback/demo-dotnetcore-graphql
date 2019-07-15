using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DemoDotNetCoreGraphQL.API
{
    public class BlogSchema : Schema
    {
        public BlogSchema(IServiceProvider serviceProvider)
        : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<BlogQuery>();

        }
    }
}
