using CompiledQuery.States;

namespace CompiledQuery.Data;

internal static class OrderItemData
{
    public static List<OrderItem> OrderItems { get; } =
    [
        // orderId 1
        new() { ProductId = 1, Id = 1, Quantity = 2, UnitPrice = 49.99m },
        new() { ProductId = 2, Id = 2, Quantity = 1, UnitPrice = 29.99m },

        // orderId 2
        new() { ProductId = 1, Id = 3, Quantity = 1, UnitPrice = 49.99m },
        new() { ProductId = 2, Id = 4, Quantity = 3, UnitPrice = 29.99m },
        new() { ProductId = 1, Id = 5, Quantity = 2, UnitPrice = 49.99m },
        new() { ProductId = 2, Id = 6, Quantity = 1, UnitPrice = 29.99m },

        // orderId 3
        new() { ProductId = 1, Id = 7, Quantity = 4, UnitPrice = 49.99m },
        new() { ProductId = 2, Id = 8, Quantity = 2, UnitPrice = 29.99m }
    ];
}
