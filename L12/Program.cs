using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12{
    internal class Program{
        static void Main(string[] args){

            Console.WriteLine("Enter 'Y' to yes and 'N' to no");
            Console.WriteLine("");
            Console.WriteLine("Do you have friends? ");            
            Console.Write(">>> ");
            string A = Console.ReadLine();
            Console.WriteLine("Do you like programming? ");
            Console.Write(">>> ");
            string B = Console.ReadLine();

            if (A == "Y" && B == "Y") {
                Console.WriteLine("You have friends and you like to programming");
            }else if (A == "N" && B == "Y") { 
                Console.WriteLine("You dont have friends, don't worry C# is here for ya");    //Avarage C# programers :)
            }else if (A == "Y" && B == "N") {
                Console.WriteLine("You have friends, but programming is to your beach");
            }else if (A == "N" && B == "N"){
                Console.WriteLine("Proverbs 14:23");
            }else{
                Console.WriteLine("Read again!");
            } 

            Console.WriteLine("");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
