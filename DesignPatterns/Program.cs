using DesignPatterns.BehavioralDesignPatterns;
using DesignPatterns.CreationalDesignPatterns;
using DesignPatterns.StructuralDesignPatterns;  

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder=new Builder();
            var personQuery = builder
                .SetWhere(true)
                .WithBracket("(")
                .WithEmail("psbesra@gmail.com")
                .OrWithID(10)
                .WithIsActive(true)
                .WithBracket(")")
                .WithLeftJoinTable1AndTable2("Person", "ID", "Organization", "PersonID")
                .GetPersonQuery();

            Console.WriteLine(personQuery.ToString());
        }
    }
}