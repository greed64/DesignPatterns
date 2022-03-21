using DesignPatterns.Builder.Models;

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

        public IModel Build()
        {
            return _address;
        }
    }
}
