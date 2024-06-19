using CompiledQuery.States;

namespace CompiledQuery.Data;

internal static class OrderData
{
    public static List<Order> Orders { get; } =
    [
        new()
        {
            OrderId = 1,
            CustomerId = 1,
            OrderDate = DateTime.Now.AddDays(-10),
            TotalAmount = 149.95m,
            Status = "Completed"
        },
        new()
        {
            OrderId = 2,
            CustomerId = 2,
            OrderDate = DateTime.Now.AddDays(-20),
            TotalAmount = 99.99m,
            Status = "Pending"
        },
    ];
}
