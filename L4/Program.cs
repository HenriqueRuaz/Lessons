using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4
{
    class Program{
        static void Main(string[] args){

            string phrase = "Henrique Ruaz";

            Console.WriteLine("Word1" + "Word2");      
            Console.WriteLine("Word1 \nWord2");     
            Console.WriteLine("Word1\"Word2");

            Console.WriteLine(phrase.Length);       //Give me the number of characters
            Console.WriteLine("Word1".Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());


            Console.WriteLine(phrase.Contains("Ruaz"));     //Parameter: True or False
            Console.WriteLine(phrase.Contains("Henry"));

            Console.WriteLine(phrase[9]);
            Console.WriteLine(phrase.IndexOf("R"));

            Console.WriteLine(phrase.Substring(9, 3));     //n1 start index, n2 length
            Console.WriteLine(phrase.Substring(9, 10));    //It does not show

            Console.ReadLine();
        }
    } 
}
