namespace GrapQL_Project
{
    public class PersonType : GraphQL.Types.ObjectGraphType<Person>
    {
        public PersonType()
        {
            Field(p => p.ID).Description("Person ID");
            Field(p => p.FirstName).Description("Person FirstName");
            Field(p => p.LastName).Description("Person LastName");
            Field(p => p.Email).Description("Person Email");

        }
    }
}
