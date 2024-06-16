namespace DZPract13_06_2024.Models
{
	public class Movie
	{
		public string Name { get; set; }
		public string Director { get; set; }
		public string Genre { get; set; }
		public string PreviewText { get; set; }
		public List<DateTime> Sessions { get; set; }

	}
}
