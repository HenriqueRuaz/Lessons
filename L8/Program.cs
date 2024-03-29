using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8
{
    internal class Program
    {
        static void Main(string[] args){

            string word1, word2, word3;

            Console.Write("Enter a color: ");
            word1 = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            word2 = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            word3 = Console.ReadLine();

            Console.WriteLine("Roses are " + word1);
            Console.WriteLine(word2 + " are blue");
            Console.WriteLine("I love " + word3);

            Console.WriteLine("");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();

        }
    }
}
