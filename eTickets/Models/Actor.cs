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
        public string ProfilePicture { get; set; }  
        public string FullName { get; set; }
        public string Bio { get; set; }      
    }
}
