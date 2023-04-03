using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display (Name="Cinema Logo")]
        public string Logo { get; set; }
		[Display(Name = "Cinema Name")]
		public string Name { get; set; }
		[Display(Name = "Cinema Description")]
		public string Description {get; set;}

        //Relationships
        public List<Movie> Movies { get; set; } 
    }
}
