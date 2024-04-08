using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L22{ 
	internal class Program{
		static void Main(string[] args){
			
			string Name; 
			string Pass;


			Security Login = new Security(); //object


			Console.WriteLine("-Register ");
			Console.WriteLine("");

			Console.Write("Enter your User_Name: ");
			Name = Console.ReadLine();
			Login.UserName = Name;

			Console.Write("Enter your Password: ");
			Pass = Console.ReadLine();
			Login.EnterPassWord = Pass;

			
			Console.WriteLine("Your User_Name is: " + Login.UserName);
			Console.WriteLine("Your Password is: " + Login.EnterPassWord);
			

			Console.WriteLine("successful login");
			
			
			Console.WriteLine("");
			Console.WriteLine("Press Enter to Exit!");
			Console.ReadLine();
		}
	}
}
