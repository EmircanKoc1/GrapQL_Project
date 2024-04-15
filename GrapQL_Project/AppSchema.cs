namespace GrapQL_Project
{
    public class AppSchema  : GraphQL.Types.Schema
    {
        public AppSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetService<RootQuery>();
            Mutation = serviceProvider.GetService<RootMutation>();
         
            
        }
    }
}
