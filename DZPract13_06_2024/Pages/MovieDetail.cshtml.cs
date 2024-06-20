using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDataLibrary;
using MovieLibrary;

namespace Practic13._06._2024.Pages
{
    public class MovieDetailModel : PageModel
    {
        private IMovieRepository _movieRepository;
       
        public Movie Movie { get; set; }
        public MovieDetailModel(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }


        public void OnGet(string name)
        {
            Movie = _movieRepository.Movies.FirstOrDefault(x => x.Name == name);     
        }
    }
}
