using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using ANZ104AngularDemo.Queries.Container;
using System;

namespace ANZ104AngularDemo.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}