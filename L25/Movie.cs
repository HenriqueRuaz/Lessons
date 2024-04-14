using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L25{
	internal class Movie{

		public string Name;
		public string Director;
		private string Rating;

		public Movie(string aName, string aDirector, string aRating){	

			Name = aName;
			Director = aDirector;
			realRating = aRating;
			
		}
		public string realRating{ 

			get { return Rating; }
			set { 
				if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR"){

					Rating = value;
				}else{

					Rating = "NR";
				 }
			}
		}
	}
}
