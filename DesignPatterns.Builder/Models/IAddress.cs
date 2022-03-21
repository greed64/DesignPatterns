namespace DesignPatterns.Builder.Models
{
    public interface IAddress: IModel
    {
        string FirstLine { get; set; }
        string SeccondLine { get; set; }
    }
}