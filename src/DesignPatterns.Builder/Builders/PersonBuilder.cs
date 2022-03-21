using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder.Builders
{
    public class PersonBuilder : IPersonBuilder
    {
        private readonly IAddressBuilder _addressBuilder;
        private readonly IPerson _person = new Person();

        public PersonBuilder(IAddressBuilder addressBuilder)
        {
            _addressBuilder = addressBuilder;
        }
        public IPersonBuilder SetPersonalData(string firstName, string lastName, int age)
        {
            _person.FirstName = firstName;
            _person.LastName = lastName;
            _person.Age = age;

            return this;
        }

        public IPersonBuilder SetAddress(string firstLine, string seccondLine)
        {
            _person.Address = _addressBuilder.SetAddress(firstLine, seccondLine).Build();

            return this;
        }

        public IPerson Build()
        {
            return _person;
        }
    }
}