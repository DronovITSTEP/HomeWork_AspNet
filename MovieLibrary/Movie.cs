using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
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
