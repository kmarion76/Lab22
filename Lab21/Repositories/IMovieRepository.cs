using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21.Models;

namespace Lab21.Repositories
{
    public interface IMovieRepository
    {
        List<MovieViewModel> Get();
        void Save(MovieViewModel movie);
    }
}
