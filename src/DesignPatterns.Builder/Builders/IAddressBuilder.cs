using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder.Builders
{
    public interface IAddressBuilder : IBuilder<IAddress>
    {
        IAddressBuilder SetAddress(string firstLine, string seccondLine);
    }
}
