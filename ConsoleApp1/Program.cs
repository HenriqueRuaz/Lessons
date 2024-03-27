using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1{
    internal class Program{
        static void Main(string[] args){

            string phrase = "characters";
            char letter = 'A';
            int integerNumber = 1234567890, integerNumber2 = -1234567890;
            float div7by2 = 3.5F;
            double pi = 3.14169;
            decimal precise = 21.098M;
            bool realOrNot = false, notOrReal = true;

            Console.WriteLine(phrase + '\n' + letter + '\n' + integerNumber + '\n' + integerNumber2 +
                '\n' + div7by2 + '\n' + pi + '\n' + precise + '\n' + realOrNot + '\n' + notOrReal);

            Console.ReadLine();
        }
    }
}
