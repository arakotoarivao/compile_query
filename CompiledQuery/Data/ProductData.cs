using CompiledQuery.States;

namespace CompiledQuery.Data;

internal static class ProductData
{
    public static List<Product> Products { get; } =
    [
        new Product
        {
            ProductId = 1,
            Name = "Product A",
            Description = "Description of Product A",
            Price = 49.99m,
            StockQuantity = 100,
            AddedDate = DateTime.Now.AddDays(-90)
        },
        new Product
        {
            ProductId = 2,
            Name = "Product B",
            Description = "Description of Product B",
            Price = 29.99m,
            StockQuantity = 50,
            AddedDate = DateTime.Now.AddDays(-120)
        }
    ];
}
