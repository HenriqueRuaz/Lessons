using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L21{
	internal class Program{
		static void Main(string[] args){

			bool loop = false;
			double k1, k2;

			do { 
			try{
				Console.Write("Enter a number: ");
				k1 = Convert.ToDouble(Console.ReadLine());
				Console.Write("Enter a second number: ");
				k2 = Convert.ToDouble(Console.ReadLine());
				
				Console.WriteLine($"{k1} + {k2} = " + Sum(k1, k2));	
				Console.WriteLine($"{k1} - {k2} = " + Sub(k1, k2));	
				Console.WriteLine($"{k1} * {k2} = " + Mult(k1, k2));	
				Console.WriteLine($"{k1} / {k2} = " + Div(k1, k2));	

				loop = true;
			}
			catch(Exception e){
				Console.WriteLine("");
				Console.WriteLine(e.Message);
				Console.WriteLine("");
			}
			}while(!loop);

			
			
			
			Console.WriteLine("");
			Console.WriteLine("Press Enter to Exit!");
			Console.ReadLine();
		}
		static double Sum(double x, double y){

			double result = 0;

			result = x+y;

			return result;
		}
		static double Sub(double x, double y){

			double result = 0;

			result = x-y;

			return result;
		}
		static double Mult(double x, double y){

			double result = 0;

			result = x*y;

			return result;
		}
		static double Div(double x, double y){

			double result = 0;

			result = x/y;

			return result;
		}

	}
}
