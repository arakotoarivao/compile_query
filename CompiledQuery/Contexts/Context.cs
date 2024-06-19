using CompiledQuery.States;
using Microsoft.EntityFrameworkCore;

namespace CompiledQuery.Contexts;

internal class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=admin;Database=compiledquery");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(x => x.CustomerId);
            entity.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            entity.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            entity.Property(x => x.Email).IsRequired().HasMaxLength(200);
            entity.Property(x => x.PhoneNumber).HasMaxLength(20);
            entity.Property(x => x.Address).HasMaxLength(300);
            entity.Property(x => x.RegistrationDate).IsRequired();
            //entity.HasData(CustomerData.Customers);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(x => x.ProductId);
            entity.Property(x => x.Name).IsRequired().HasMaxLength(200);
            entity.Property(x => x.Description).HasMaxLength(1000);
            entity.Property(x => x.Price).IsRequired();
            entity.Property(x => x.StockQuantity).IsRequired();
            entity.Property(x => x.AddedDate).IsRequired();
            //entity.HasData(ProductData.Products);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(x => x.OrderId);
            entity.Property(x => x.OrderDate).IsRequired();
            entity.Property(x => x.TotalAmount).IsRequired();
            entity.Property(x => x.Status).IsRequired().HasMaxLength(50);
            //entity.HasData(OrderData.Orders);

            entity.HasOne<Customer>()
                  .WithMany()
                  .HasForeignKey(x => x.CustomerId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Quantity).IsRequired();
            entity.Property(x => x.UnitPrice).IsRequired();
            //entity.HasData(OrderItemData.OrderItems);

            entity.HasOne<Product>()
                  .WithMany()
                  .HasForeignKey(x => x.ProductId)
                  .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne<Order>()
                  .WithMany(x => x.OrderItems)
                  .HasForeignKey(x => x.Id)
                  .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
