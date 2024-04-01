using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11{
    internal class Program{
        static void Main(string[] args){

            Console.WriteLine(Cube(2));

            Console.WriteLine("");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
        static double Cube(int k1){


            double n1 = Math.Pow(k1, 3);
            return n1;

            
        }

    }
}
