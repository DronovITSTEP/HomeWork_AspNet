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
			if (name != null)
			{
				Movie = _movieRepository.Movies.FirstOrDefault(m => m.Name == name);
				ViewData["Title"] = "Редактирование фильма";
			}
			else
			{
				ViewData["Title"] = "Добавление фильма";

            }			
		}
		public IActionResult OnPost(Movie movie)
		{
			_movieRepository.EditMovie(movie);

			return RedirectToPage("/sessions");
		}
	}
}
