using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder.Builders
{
    public interface IPersonBuilder : IBuilder<IPerson>
    {
        IPersonBuilder SetPersonalData(string firstName, string lastName, int age);

        IPersonBuilder SetAddress(string firstLine, string seccondLine);
    }
}