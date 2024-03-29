using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9{
    internal class Program{
        static void Main(string[] args){

            int[] history = { 1789, 1861, 1923 };

            Console.WriteLine("In " + history[0] + " was the french revolution");
            Console.WriteLine("In " + history[1] + " Abraham Lincoln is sworn");
            Console.WriteLine("In " + history[2] + " Disney was founded");

            Console.WriteLine("");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine(); 
        }
    }
}
