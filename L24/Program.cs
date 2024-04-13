using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L24{
	internal class Program{
		static void Main(string[] args){

			
			Grades student1 = new Grades("John", 8.4);
			Console.WriteLine(student1.entrance());

			Grades student2 = new Grades("Sophie", 5.5);
			Console.WriteLine(student2.entrance());
			
			Grades student3 = new Grades("Arthur", 6.7);
			Console.WriteLine(student3.entrance());

			Grades student4 = new Grades("Alfred", 2.2);
			Console.WriteLine(student4.entrance());


			Console.WriteLine("");
			Console.WriteLine("Press Enter to Exit!");
			Console.ReadLine();
		}
	}
}
