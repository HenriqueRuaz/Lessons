using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L25{
	internal class Program{
		static void Main(string[] args){
			
			Movie movie1 = new Movie("The Avangers", "Joss Whedon", "R");
			Movie movie2 = new Movie("Shrek", "Adam Adomson", "PG");
			
			Console.WriteLine(movie1.realRating);

			Console.WriteLine("");
			Console.WriteLine("Press Enter to Exit!");
			Console.ReadLine();
		}
	}
}
