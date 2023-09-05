using ConsoleApp_TestCodeFirst;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void CreateDatabase()
    {
        using (var dbcontext = new ProductsContext())
        {
            bool result =  dbcontext.Database.EnsureCreated();
            Console.WriteLine(result);
        }
    }

    public static void DeleteDatabase()
    {
        using (var context = new ProductsContext())
        {
            bool deleted = context.Database.EnsureDeleted();
            Console.WriteLine(deleted);
        }
    }

    static void Main(string[] args)
    {
        CreateDatabase();
    }
}
