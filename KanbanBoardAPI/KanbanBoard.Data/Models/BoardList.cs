using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KanbanBoard.Data.Models
{
    public class BoardList
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 1)]
        public string ListTitle { get; set; }

        [ForeignKey("BoardId")]
        public Board Board { get; set; }
        public int BoardId { get; set; }

        public List<Card>? Cards { get; set; }
    }
}
