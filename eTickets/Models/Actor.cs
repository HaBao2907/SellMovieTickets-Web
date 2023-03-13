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
        [Display(Name ="ProfilePictureURL")]
        public string ProfilePicture { get; set; }
		[Display(Name = "Full Name Actors")]
		public string FullName { get; set; }
		[Display(Name = "Biography")]
		public string Bio { get; set; }      

        //Relationships
        public List<Actors_Movies> Actor_Movies { get; set; }
    }
}
