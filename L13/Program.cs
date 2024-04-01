using System;

namespace L13
{
    internal class Program{
        static void Main(string[] args){

            Console.WriteLine(Max(1, 10, 100));
            Console.WriteLine(Max(10, 100, 1));
            Console.WriteLine(Max(100, 1, 10));

            Console.WriteLine(Max(1, 100, 100));
            Console.WriteLine(Max(100, 100, 1));
            Console.WriteLine(Max(100, 1, 100));

            Console.WriteLine("");
            Console.WriteLine("Press Enter to Exit!");
            
            Console.ReadLine();

        }
        static int Max(int k1, int k2, int k3 ){  
           /* if(k1 > k2){

                result = k1;
            }else{

                result = k2;
            }

            return result;*/             
            int result;

            if(k1 >= k2 && k1 >= k3){

                result = k1;
            }else if(k2 >= k1 && k2 >= k3){
                
                result = k2;
            }else{
                
                result = k3;
            }
            
            return result;
        }
    }
}   
