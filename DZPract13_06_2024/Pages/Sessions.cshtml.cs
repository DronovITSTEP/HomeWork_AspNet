using DZPract13_06_2024.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace DZPract13_06_2024.Pages
{
    public class SessionsModel : PageModel
    {
        public List<Movie> Movies { get; set; }


        public SessionsModel()
        {
            Movies = new List<Movie>
            {
                new Movie
                {
                    Name="Огненный лис",
                    Director="Дмитрий Шпиленок",
                    Genre="Фэнтези",
                    PreviewText="Фильм Огненный лис это семейное кино " +
                    "о живой дикой природе про лисёнка, " +
                    "родившегося самым слабым в своей семье, " +
                    "но именно он выживает во время нападения медведя.",
                    Sessions=new List<DateTime>
                    {
						new DateTime(13,06,2024,13,00,00),
						new DateTime(13,06,2024,15,00,00),
						new DateTime(13,06,2024,17,00,00)
					}
				},
                new Movie
                {
					Name="Ненормальный",
					Director="Илья Маланин",
					Genre="Драмы",
					PreviewText="Фильм Ненормальный расскажет о восьмилетнем Коле, " +
                    "страдающем от врождённой болезни. Один новый мамин знакомый берётся " +
                    "за здоровье мальчика, пробуя свою новую систему гимнастики в деле. ",
					Sessions=new List<DateTime>
					{
						new DateTime(13,06,2024,10,00,00),
						new DateTime(13,06,2024,12,00,00),
						new DateTime(13,06,2024,14,00,00)
					}
				},
                new Movie
                {
					Name="По Фрейду",
					Director="Мэтт Браун",
					Genre="Драмы",
					PreviewText="Фильм По Фрейду развернётся в Лондоне 1939 года через два дня после начала " +
                    "Второй Мировой войны и вторжения Германии на территорию Польши. " +
                    "На фоне этих событий профессор и автор концепции психоанализа Зигмунд Фрейд " +
                    "встречает писателя Клайва Льюэса. В беседе о главных вещах мироздания зарождаются " +
                    "предпосылки к дальнейшему творчеству автора знаменитых Хроник Нарнии.",
					Sessions=new List<DateTime>
					{
						new DateTime(13,06,2024,16,00,00),
						new DateTime(13,06,2024,18,00,00),
						new DateTime(13,06,2024,20,00,00)
					}
				}

            };

        }

        public void OnGet()
        {
            ViewData["Movies"] = Movies;
        }
    }
}
