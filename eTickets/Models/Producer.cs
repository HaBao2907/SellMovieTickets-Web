using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using eTickets.Data.Base;

namespace eTickets.Models
{
    public class Producer: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is empty")]
        public string ProfilePicture { get; set; }
		[Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is empty")]
        public string FullName { get; set; }
		[Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is empty")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
