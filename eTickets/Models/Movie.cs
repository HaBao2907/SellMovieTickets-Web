﻿using eTickets.Data.Base;
using eTickets.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie : IEntityBase
	{
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }    
        public string Price { get; set; }
        public string ImageURL { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }   
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actors_Movies> Actor_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }


    }
}
