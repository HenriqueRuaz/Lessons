using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

// No ai needed
// No copypast

namespace L14{
    internal class Program{
        static void Main(string[] args){

            Console.WriteLine("Calculator");
            Console.WriteLine("");

            Console.WriteLine("Chose an operator: [+] [-] [*] [/] [^p] [sqrt] [log]");
            Console.Write(">>> ");
            string op = Console.ReadLine();

            if(op == "+" || op == "-" || op == "*" || op == "/" || op == "^p" || op  == "sqrt" || op == "log") {
                if(op == "+" || op == "-" || op == "*" || op == "/" || op == "^p") {

                    Console.WriteLine("Chose a number");
                    Console.Write(">>> ");
                    double k1 = Convert.ToDouble(Console.ReadLine());
            
                    Console.WriteLine("Chose a second number");
                    Console.Write(">>> ");
                    double k2 = Convert.ToDouble(Console.ReadLine());
            
                    Console.WriteLine("");
                    Console.Write("Result: ");
               
                    if (op == "+"){
                        double sum = k1 + k2;
                        Math.Abs(sum);
                        Console.WriteLine($"{k1} + {k2} = {sum}"); 
                    }else if(op == "-"){
                        double sub = k1 - k2;
                        Math.Abs(sub);
                        Console.WriteLine($"{k1} - {k2} = {sub}");
                    }else if(op == "*"){
                        double mult = k1 * k2;
                        Math.Abs(mult);
                        Console.WriteLine($"{k1} * {k2} = {mult}");
                    }else if(op == "/"){
                        double div = k1 / k2;
                        Math.Abs(div);
                        Console.WriteLine($"{k1} / {k2} = {div}");
                    }else if(op == "^p"){
                        double pow = Math.Pow(k1, k2);
                        Math.Abs(pow);
                        Console.WriteLine($"{k1} ^ {k2} = {pow}");
                    }
                }

                if (op == "sqrt" || op == "log") {  
                    Console.WriteLine("Chose a number");
                    Console.Write(">>> ");
                    double k1 = Convert.ToDouble(Console.ReadLine()); 
                
                    if(op == "sqrt"){
                        double sqrt = Math.Sqrt(k1);
                        Console.WriteLine($"square root of {k1} = {sqrt}");
                    }else if(op == "log"){
                        double log = Math.Log10(k1);
                        Console.WriteLine($"log {k1} = {log} ");
                    }
                }

            }else{
                Console.WriteLine("Try again!"); 
            }

            Console.WriteLine("");
            Console.WriteLine("Press Enter to Exit!");
		    Console.ReadLine();
        }
    }
}

