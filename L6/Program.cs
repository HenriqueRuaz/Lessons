using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6{
    internal class Program{
        static void Main(string[] args){

            Console.WriteLine("Hello");
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.Write("Hello " + name + ", you have a nice name!");

            Console.WriteLine("");
            Console.WriteLine("Enter to exit");
            Console.ReadLine();

        }
    }
}
