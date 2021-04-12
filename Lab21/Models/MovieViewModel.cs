using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21.Models
{
    public class MovieViewModel
    {
        
       public MovieViewModel(string title, MovieGenre genre)
        {
            Title = title;
            Genre = genre;
        }

        public int ID { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public MovieGenre Genre { get; set; }
        public int Year { get; set; }
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Actors { get; set; }
        public string Directors { get; set; }
    }
}
