namespace Acme.Hello.Platform.Generic.Domain.Model.Entities;

public class Developer
{
    public Guid Id { get;} = Guid.NewGuid();
    public string FirstName { get; }
    public string LastName { get; }

    public Developer(string firstName, string lastName)
    {
        FirstName = string.IsNullOrWhiteSpace(firstName) 
            ? string.Empty
            : firstName.Trim();
        LastName = string.IsNullOrWhiteSpace(lastName)
            ? string.Empty
            : lastName.Trim(); //trim elimina los espacios en blanco
    }

    public string GetFullName() => "$" + FirstName + " " + LastName;
    
    public bool IsAnyNameEmpty() => string.IsNullOrEmpty(FirstName) ||
                                    string.IsNullOrEmpty(LastName);
    
    
}