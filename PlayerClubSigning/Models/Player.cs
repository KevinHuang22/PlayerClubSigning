using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerClubSigning.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }

        [Display(Name = "Place of Birth")]
        public string PlaceOfBirth { get; set; }
        public int? TeamId { get; set; }
        public Team Team { get; set; }
    }
}
