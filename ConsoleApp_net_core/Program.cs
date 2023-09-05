using ConsoleApp_net_core;
using Microsoft.EntityFrameworkCore;



namespace main;

public class Program
{
    static void Main(string[] args)
    {
        DeleteDatabase();
        CreateDatabase();
    }

    public static void CreateDatabase()
    {
        using (var dbcontext = new Context())
        {
            String databasename = dbcontext.Database.GetDbConnection().Database;// mydata

            Console.WriteLine("Tạo " + databasename);

            bool result =  dbcontext.Database.EnsureCreated();
            string resultstring = result ? "tạo  thành  công" : "đã có trước đó";
            Console.WriteLine($"CSDL {databasename} : {resultstring}");
        }
    }

    public static void DeleteDatabase()
    {

        using (var context = new Context())
        {
            String databasename = context.Database.GetDbConnection().Database;
            Console.Write($"Có chắc chắn xóa {databasename} (y) ? ");
            bool deleted =  context.Database.EnsureDeleted();
            string deletionInfo = deleted ? "đã xóa" : "không xóa được";
            Console.WriteLine($"{databasename} {deletionInfo}");
        }

    }

}