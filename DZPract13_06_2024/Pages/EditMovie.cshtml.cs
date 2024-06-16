using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDataLibrary;
using MovieLibrary;
using System.Xml.Linq;

namespace DZPract13_06_2024.Pages
{
    public class EditMovieModel : PageModel
    {
        private readonly IMovieRepository _movieRepository;
        public Movie Movie { get; set; }
        public EditMovieModel(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public void OnGet(string name)
        {
            Movie = _movieRepository.Movies.FirstOrDefault(m => m.Name == name);
        }
        public IActionResult OnPost(Movie movie) {
            Movie = _movieRepository.Movies.FirstOrDefault
                (m => m.Name == movie.Name);
            if (Movie != null)
            {
                Movie.Director = movie.Director;
                Movie.PreviewText = movie.PreviewText;
            }
            return RedirectToPage("/sessions");
        }
    }
}
