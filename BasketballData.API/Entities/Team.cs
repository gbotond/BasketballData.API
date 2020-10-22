using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BasketballData.API.Entities
{
    public class Team
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(5)]
        public string ShortName { get; set; }          

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        public ICollection<Game> HomeGames { get; set; }
            = new List<Game>();
        public ICollection<Game> AwayGames { get; set; }
            = new List<Game>();
    }
}
