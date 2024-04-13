using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L24{
	internal class Grades{

		public string name;
		public double grades;

		public Grades (string  Sname, double Sgrades)
		{
			name = Sname;
			grades = Sgrades;
			Console.WriteLine("Student : " + Sname + " " + grades);
		}
		//entrance to university
		public bool entrance (){
			
			if (grades < 3.5){

				return false;
			}else{
				return true;
			}
			
		}
	}
}
