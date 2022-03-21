namespace DesignPatterns.Builder.Builders
{
    public interface IAddressBuilder : IBuilder
    {
        IAddressBuilder SetAddress(string firstLine, string seccondLine);
    }
}
