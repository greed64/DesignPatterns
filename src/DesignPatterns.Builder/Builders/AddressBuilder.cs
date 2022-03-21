using DesignPatterns.Builder.Models;
using System;

namespace DesignPatterns.Builder.Builders
{
    public class AddressBuilder : IAddressBuilder
    {
        private readonly IAddress _address = new Address();

        public IAddressBuilder SetAddress(string firstLine, string seccondLine)
        {
            _address.FirstLine = firstLine;
            _address.SeccondLine = seccondLine;

            return this;
        }

        public IAddress Build()
        {
            Validate();
            return _address;
        }

        private void Validate()
        {
            if (string.IsNullOrEmpty(_address.FirstLine))
            {
                throw new ArgumentException("FirstLine");
            }
            if (string.IsNullOrEmpty(_address.SeccondLine))
            {
                throw new ArgumentException("SeccondLine");
            }
        }
    }
}
