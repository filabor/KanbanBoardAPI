using Microsoft.EntityFrameworkCore;
using KanbanBoard.Data.Data;

namespace KanbanBoard.Data
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<KanbanBoardContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("KanbanBoardDB")));
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}