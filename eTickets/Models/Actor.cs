using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
       [Display(Name ="Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="FullNmae")]
        public string FullName { get; set; }
        [Display(Name="Bio")]
        public string Bio { get; set; }

        //Realtionship between movie and actor many to many using join table actor_movie
        public List<Actor_Movie> Actors_Movies {get; set;}
    }
}
