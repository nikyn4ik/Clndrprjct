using System.ComponentModel.DataAnnotations;

namespace Clndrprjct.Models
{
    public class CalendarEvent
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public bool AllDay { get; set; }

        [Required]
        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
