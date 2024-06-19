namespace CompiledQuery.States;

internal class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OrderItem> OrderItems { get; set; } = [];
    public decimal TotalAmount { get; set; }
    public string Status { get; set; } = string.Empty;
}
