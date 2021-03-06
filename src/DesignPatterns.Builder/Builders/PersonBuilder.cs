using DesignPatterns.Builder.Models;
using System;

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
            Validate();
            return _person;
        }

        private void Validate() {
            if (string.IsNullOrEmpty(_person.FirstName)) {
                throw new ArgumentException("FirstName");
            }
            if (string.IsNullOrEmpty(_person.LastName))
            {
                throw new ArgumentException("LastName");
            }
            if (_person.Age < 0 || _person.Age > 120)
            {
                throw new ArgumentException("Age");
            }
            if (_person.Address is null)
            {
                throw new ArgumentException("Address");
            }
        }
    }
}