using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        [Display(Name="Profile Picture")]
        public string ProfilePicture { get; set; }
		[Display(Name = "Full Name")]
		public string FullName { get; set; }
		[Display(Name = "Biography")]
		public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
