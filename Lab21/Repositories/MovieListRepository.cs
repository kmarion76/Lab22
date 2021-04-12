using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21.Models;

namespace Lab21.Repositories
{
    public class MovieListRepository : IMovieRepository
    {

        List<MovieViewModel> result = new List<MovieViewModel>();
        public List<MovieViewModel> Get()
        {
            result.Add(new MovieViewModel("Ride Along", MovieGenre.Comedy));
            result.Add(new MovieViewModel("Avengers", MovieGenre.Action));
            result.Add(new MovieViewModel("IT", MovieGenre.Thriller));
            result.Add(new MovieViewModel("IT 2", MovieGenre.Thriller));
            result.Add(new MovieViewModel("Fast and the Furious", MovieGenre.Action));
            result.Add(new MovieViewModel("Oceans Eleven", MovieGenre.Action));
            result.Add(new MovieViewModel("Frozen", MovieGenre.Animated));
            result.Add(new MovieViewModel("Frozen 2", MovieGenre.Animated));
            result.Add(new MovieViewModel("Toy Story", MovieGenre.Animated));
            result.Add(new MovieViewModel("Toy Story 2", MovieGenre.Animated));
            result.Add(new MovieViewModel("Aladdin", MovieGenre.Animated));
            result.Add(new MovieViewModel("Godzilla", MovieGenre.SciFi));
            result.Add(new MovieViewModel("Step Brothers", MovieGenre.Comedy));
            result.Add(new MovieViewModel("Bad Boys", MovieGenre.Action));
            result.Add(new MovieViewModel("Bad Boys 2", MovieGenre.Action));
            return result;
        }

        public void Save(MovieViewModel movie)
        {
            result.Add(movie);
        }

      
    }
}
