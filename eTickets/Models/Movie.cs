﻿using eTickets.Data;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public double Price { get; set; }
        public MovieCategory MovieCategory { get; set; }


        //Realtionship between movie and actor many to many using join table actor_movie
        public List<Actor_Movie> Actors_Movies { get; set; }


        //Cinema 
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer 
        public int ProducerId { get; set; }
        [ForeignKey("CinemaId")]
        public Producer Producer  { get; set; }



    }
}
