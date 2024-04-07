using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L16{
    internal class Program { 
        static void Main(string[] args){
            
            string exit = "";
            double res1;
            int res;
            int i = 0;
            int k1;
            int cons;
            cons = 1;
            Console.Write("Enter a number: ");
            k1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Press 'z' to exit!");

            while(i < 10 && exit != "z"){           
                i++;
                res = k1*i;
                Console.WriteLine($"{k1} * {i} = {res}");

                res1 = Math.Pow(k1, ++cons);
                Console.WriteLine($"{k1} ^ {cons} = {res1}");

                exit = 
                    Console.ReadLine();

                if(i == 10) { 
                    Console.WriteLine("You can only multiply by 10 and power by 11");

                }
            }
            do { 
            
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Exit!");
		    Console.ReadLine();       
            }while(exit != "z"); //the condicion is false should end

        }
    } 
}
