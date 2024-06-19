using CompiledQuery.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CompiledQuery;

public class Program
{
    public static void Run()
    {
        using var context = new Context();
        //if (!context.Database.EnsureCreated())
        context.Database.EnsureCreated();
        context.Database.Migrate();
    }
}
