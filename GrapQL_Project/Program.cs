using GraphQL;

namespace GrapQL_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);        

            builder.Services.AddGraphQL(options =>
            {
                options.AddSystemTextJson();
                //options.AddNewtonsoftJson();
                options.AddSchema<AppSchema>();
                options.AddGraphTypes();
            });


            var app = builder.Build();

            app.UseGraphQL<AppSchema>();
            app.UseGraphQLPlayground();

          

            app.Run();
        }
    }
}
