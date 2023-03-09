using System;
using System.ComponentModel.DataAnnotations;

namespace Clndrprjct.Models
{
    public class CalendarEvent
    {
        [Key]
        public int Id { get; set; }

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
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
