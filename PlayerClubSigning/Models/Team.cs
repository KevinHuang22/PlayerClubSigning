using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerClubSigning.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Founded Year")]
        [DataType(DataType.Date)]
        public DateTime FoundedYear { get; set; }
        public string Ground { get; set; }
        public string Coach { get; set; }
        public string Region { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
