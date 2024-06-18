using DZPract13_06_2024.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDataLibrary;
using MovieLibrary;
using System.IO;

namespace DZPract13_06_2024.Pages
{
    public class SessionsModel : PageModel
    {
        private readonly IMovieRepository _movieRepository;
        public List<Movie> Movies { get; set; }


        public SessionsModel(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public void OnGet()
        {
            Movies = _movieRepository.Movies;

        }
        public void OnGetSearch(string searchString)
        {
            if (searchString != null)
            {
                var movies = _movieRepository.Movies.Where(
                    m =>
                    m.Name.Contains(searchString) ||
                    m.Genre.ToLower().Contains(searchString)
                ).ToList();
                Movies = movies;
            }
            else
            {
                Movies = _movieRepository.Movies;
            }
        }
        public IActionResult OnPostDelete(string name)
        {
            var delMovie = Movies.FirstOrDefault(m => m.Name == name);
            _movieRepository.DeleteMovie(delMovie);
            return new JsonResult(true);
        }
    }
}
