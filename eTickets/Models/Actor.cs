using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name ="ProfilePicture")]
        [Required(ErrorMessage = "Empty Picture Profile!")]
        public string ProfilePicture { get; set; }
		[Display(Name = "Full Name Actors")]
        [Required(ErrorMessage = "Empty Name Actor!")]
        [StringLength(50, MinimumLength = 3)]
        public string FullName { get; set; }
		[Display(Name = "Biography")]
        [Required(ErrorMessage = "Empty Biograhpy of Actor!")]
        public string Bio { get; set; }      

        //Relationships
        public List<Actors_Movies> Actor_Movies { get; set; }
    }
}
