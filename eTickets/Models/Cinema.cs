
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string CinemaLogo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationship one to many between Cinema and Movie

        public List<Movie> Movies { get; set; }
        
    }
}
