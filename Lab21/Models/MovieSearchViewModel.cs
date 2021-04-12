using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21.Models
{
    public class MovieSearchViewModel : Controller
    {
       public string Title { get; set; }
        public MovieGenre Genre { get; set; }
        
    }

    
}
