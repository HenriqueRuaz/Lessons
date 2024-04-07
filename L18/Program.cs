using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L18{
    internal class Program{
        static void Main(string[] args){

            int i = 0;
            int [] yes = {2, 3, 5, 7, 11, 13, 17, 19, 23};
            int position = yes.Length;

            for(i = 0; i < position; i++) {

                
                Console.WriteLine($"{i} position ->" + yes[i]);

            }
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Exit!");
		    Console.ReadLine();
        }
    }
}
