using KanbanBoard.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace KanbanBoard.Data.Data
{
    public class KanbanBoardContext : DbContext
    {
        public KanbanBoardContext(DbContextOptions<KanbanBoardContext> options) : base(options)
        {
                
        }

        public DbSet<Board> Boards { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<BoardList> BoardLists { get; set; }
    }
}
