using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L10{
    internal class Program{
        static void Main(string[] args){

            User("Henrique Ruaz");
            User("Uriel");

            Console.WriteLine("");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
        static void User(string name){

            if (name == "Henrique Ruaz"){
                Console.WriteLine("The User1_name: " + name);
                Console.WriteLine("Approved");

            }else{
                Console.WriteLine("The User2_name: " + name);
                Console.WriteLine("Not Approved");
             }

        }
    }
}
