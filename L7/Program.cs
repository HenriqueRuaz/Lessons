using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace L7{
    internal class Program{
        static void Main(string[] args){
            /*
                string phrase = "Hello World";
                int n1 = 12;

                Console.Write("Chose a number: ");
                int K1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(K1);
                Console.WriteLine(n1);
                Console.WriteLine(phrase);
                int k2 = Console.Read();
                Console.WriteLine(k2);

                Console.WriteLine("");
                Console.WriteLine("Press Enter to exit!");
                Console.ReadLine();
            */
            //Calculator:
            Console.Write("Chose a number: ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Chose the second number: ");
            int k2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("The sum is: ");
            Console.WriteLine(k1 + k2);

            Console.Write("The subtraction is: ");
            Console.WriteLine(k1 - k2);

            Console.Write("The Multiplication is: ");
            Console.WriteLine(k2 * k1);

            Console.Write("The division is: ");
            Console.WriteLine(k1 / k2);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
    }
}
