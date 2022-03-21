namespace DesignPatterns.Builder.Models
{
    public interface IPerson : IModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        IAddress Address { get; set; }
    }
}