using MovieLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDataLibrary
{
	public interface IMovieRepository
	{
		List <Movie> Movies { get; set; }
		List<Movie> GetMovies();
		void EditMovie(Movie movie);
		void DeleteMovie(Movie movie);

	}
}
