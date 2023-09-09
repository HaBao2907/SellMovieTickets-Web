using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using eTickets.Data.Base;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display (Name="Cinema Logo")]
        [Required(ErrorMessage ="Cinema logo is required!")]
        public string Logo { get; set; }
		[Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema Name is required!")]
        public string Name { get; set; }
		[Display(Name = "Cinema Description")]
        [Required(ErrorMessage = "Cinema Description is required!")]
        public string Description {get; set;}

        //Relationships
        public List<Movie> Movies { get; set; } 
    }
}
