using GraphQL;
using GraphQL.Types;

namespace GrapQL_Project
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            Name = "RootQuery";
            Description = "Burada query açıklaması yer alabilir";

            Field<StringGraphType>("mesaj")
                .Description("Burada alan ile ilgili açıklama yer alabilir")
                .Resolve(x => "Merhaba GraphQL");

            Field<NonNullGraphType<IntGraphType>>("sayi")
                .Description("her bir istek sonucu rastgele bir sayı üretilecektir")
                .Resolve(context => Random.Shared.Next(0, 100));

            Field<ListGraphType<PersonType>>("people")
                .Resolve(context => new List<Person>(){
                    new Person{ID=1, FirstName="person1", LastName="surname1"},
                    new Person{ID=2, FirstName="person2", LastName="surname2"},
                    new Person{ID=3, FirstName="person3", LastName="surname3"},
                    new Person{ID=4, FirstName="person4", LastName="surname4"}
                });


            Field<PersonType>("person")
                .Argument<NonNullGraphType<IdGraphType>>("id")
                .Resolve(context =>
                {
                    var id = context.GetArgument<int>("id");

                    List<Person> people = new List<Person>() {
                    new Person{ID=1, FirstName="person1", LastName="surname1"},
                    new Person{ID=2, FirstName="person2", LastName="surname2"},
                    new Person{ID=3, FirstName="person3", LastName="surname3"},
                    new Person{ID=4, FirstName="person4", LastName="surname4"}
                    };

                    Person? foundPerson = people.Find(p => p.ID == id);

                    if (foundPerson == null)
                    {
                        context.Errors.Add(new ExecutionError("Person not found!"));
                        return null;
                    }

                    return foundPerson;
                });
        }

    }
}
