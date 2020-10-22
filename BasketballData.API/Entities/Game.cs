using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasketballData.API.Entities
{
    public class Game
    {
        [Key]       
        public Guid Id { get; set; }
        public Guid HomeTeamId { get; set; }
        public Guid VisitorTeamId { get; set; }

        [ForeignKey("HomeTeamId")]
        public virtual Team HomeTeam { get; set; }

        [ForeignKey("VisitorTeamId")]
        public virtual Team VisitorTeam { get; set; }

        [Required]
        [MaxLength(15)]
        public string Score { get; set; }

        [Required]
        public DateTimeOffset Started { get; set; }

        [Required]
        public DateTimeOffset Finished { get; set; }
    }
}
