using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15{
    internal class Program{
        static void Main(string[] args){

            Console.WriteLine(GetDay(2));


            Console.WriteLine("");
            Console.WriteLine("Press Enter to Exit!");
		    Console.ReadLine();
        }
        static string GetDay(int dayNum){
            string dayName;

            switch (dayNum) { 
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    Console.WriteLine("Something goes wrong");
                break;
            }
                return dayName;
        }  
    }
}
