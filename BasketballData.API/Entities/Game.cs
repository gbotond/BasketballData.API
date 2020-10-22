using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasketballData.API.Entities
{
    public class Game
    {
        [Key]       
        public Guid Id { get; set; }

        [ForeignKey("VisitorTeamId")]
        public Team VisitorTeam { get; set; }

        [ForeignKey("HomeTeamId")]
        public Team HomeTeam { get; set; }

        public Guid VisitorTeamId { get; set; }

        public Guid HomeTeamId { get; set; }

        [Required]
        [MaxLength(15)]
        public string Score { get; set; }

        [Required]
        public DateTimeOffset Started { get; set; }

        [Required]
        public DateTimeOffset Finished { get; set; }
    }
}
