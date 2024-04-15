using GraphQL;
using GraphQL.Types;

namespace GrapQL_Project
{
    public class RootMutation : ObjectGraphType
    {
        public RootMutation()
        {
            Name = "RootMutation";
            Description = "Burada mutation açıklaması yer alir";

            //Field<StringGraphType>("addPerson")
            //  .Description("Add new person.")
            //  .Arguments(
            //    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "firstName" },
            //    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "lastName" })
            //  .Resolve(context =>
            //  {
            //      var firstName = context.GetArgument<string>("firstName");
            //      var lastName = context.GetArgument<string>("lastName");

            

            //      return "Başarılı";
            //  });

            Field<StringGraphType>("addPerson")
              .Description("Add new person.")
              .Argument<NonNullGraphType<PersonInputType>>("person")
              .Resolve(context =>
              {
                  var person = context.GetArgument<Person>("person");

                  
                  return "Başarılı";
              });
                  }

    }
}
