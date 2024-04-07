using System;using System.Collections.Generic;using System.Diagnostics.Eventing.Reader;using System.Linq;using System.Text;using System.Threading.Tasks;namespace L17{	internal class Program{		static void Main(string[] args){			string KeyCode = "7355608";			string Code = "";			int att = 0;			int explosion = 3;			bool defused = true;			do{
				
				if(att < explosion) {
				Console.Write("Enter the bomb code: ");
				Code = Console.ReadLine();
				att++;									

				}else{									
					defused = false;	
				}

			}while(Code != KeyCode && defused == true);						if(defused){

				Console.WriteLine("Counter-terrorist Win!");
			}
			else{

				Console.WriteLine("Terrorist Win!");
			}			
			Console.WriteLine("");
			Console.WriteLine("Press Enter to Exit!");
			Console.ReadLine();		}	}}