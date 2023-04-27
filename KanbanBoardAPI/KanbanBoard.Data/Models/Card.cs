using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanbanBoard.Data.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string CardTitle { get; set; }

        [ForeignKey("BoardListId")]
        public BoardList BoardList { get; set; }
        public int BoardListId { get; set; }

        [Column(TypeName = "Date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime DueDate { get; set; }

        public string? Description { get; set; }
    }
}
