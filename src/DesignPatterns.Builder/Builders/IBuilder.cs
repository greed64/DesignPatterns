using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder.Builders
{
    public interface IBuilder<TModel> where TModel : IModel
    {
        TModel Build();
    }
}