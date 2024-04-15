using GraphQL.Types;

namespace GrapQL_Project
{
    public class PersonInputType  : InputObjectGraphType<Person>
    {
        public PersonInputType()
        {
            Field(p => p.FirstName);
            Field(p => p.LastName);


        }
    }
}
