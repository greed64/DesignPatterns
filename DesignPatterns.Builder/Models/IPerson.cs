namespace DesignPatterns.Builder.Models
{
    interface IPerson : IModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        IAddress Address { get; set; }
    }
}