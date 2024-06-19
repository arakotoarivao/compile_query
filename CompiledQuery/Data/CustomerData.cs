using CompiledQuery.States;

namespace CompiledQuery.Data;

internal static class CustomerData
{
    public static List<Customer> Customers { get; } =
    [
        new()
        {
            CustomerId = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            PhoneNumber = "123-456-7890",
            Address = "123 Main St, Anytown, USA",
            RegistrationDate = DateTime.Now.AddDays(-30)
        },
        new()
        {
            CustomerId = 2,
            FirstName = "Jane",
            LastName = "Smith",
            Email = "jane.smith@example.com",
            PhoneNumber = "987-654-3210",
            Address = "456 Oak Ave, Othertown, USA",
            RegistrationDate = DateTime.Now.AddDays(-60)
        }
    ];
}
