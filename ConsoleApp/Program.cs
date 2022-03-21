using DesignPatterns.Builder.Builders;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Builders();
        }

        static void Builders()
        {
            var addressBuilder = new AddressBuilder();
            var address = addressBuilder
                .SetAddress("aaa", "bbb")
                .Build();

            var personBuilder = new PersonBuilder(addressBuilder);
            var person = personBuilder
                .SetPersonalData("John", "Snow", 28)
                .SetAddress("aa", "bb")
                .Build();
        }
    }
}
