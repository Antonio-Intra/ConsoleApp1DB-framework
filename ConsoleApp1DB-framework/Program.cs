using ConsoleApp1DB_framework.entities;

namespace ConsoleApp1DB_framework;

internal class Program
{
    private static void Main(string[] args)
    {
        using var context = new BancoDB();

        Console.WriteLine("Aplicações financeiras cadastradas no banco de dados:");
        Aplicaçãofinanceira ap = new("LCA", 1000, true);
        context.aplicaçãofinanceiras.Add(ap);
        context.SaveChanges();

    }
}