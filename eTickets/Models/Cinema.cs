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
        public int CinemaId { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description {get; set;}

    }
}
