using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder.Builders
{
    public interface IBuilder
    {
        IModel Build();
    }
}