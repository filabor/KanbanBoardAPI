using System.ComponentModel.DataAnnotations;

namespace KanbanBoard.Data.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string BoardTitle { get; set; }

        public List<BoardList>? BoardLists { get; set; }
    }
}
