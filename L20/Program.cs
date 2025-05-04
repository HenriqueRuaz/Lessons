using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Teste3{
	internal class Program{
		static void Main(string[] args){
			
			int a = 9;
			int b = 9;

			int[,] arr = {
					{1, 2, 3, 4, 5, 6, 7, 8, 9},
					{1, 2, 3, 4, 5, 6, 7, 8, 9},
					{1, 2, 3, 4, 5, 6, 7, 8, 9},
					{1, 2, 3, 4, 5, 6, 7, 8, 9},
					{1, 2, 3, 4, 5, 6, 7, 8, 9},
					{1, 2, 3, 4, 5, 6, 7, 8, 9},
					{1, 2, 3, 4, 5, 6, 7, 8, 9},
					{1, 2, 3, 4, 5, 6, 7, 8, 9},
					{1, 2, 3, 4, 5, 6, 7, 8, 9},
			};
			int[,] arr2 = {
					{1, 1, 1, 1, 1, 1, 1, 1, 1},
					{2, 2, 2, 2, 2, 2, 2, 2, 2},
					{3, 3, 3, 3, 3, 3, 3, 3, 3},
					{4, 4, 4, 4, 4, 4, 4, 4, 4},
					{5, 5, 5, 5, 5, 5, 5, 5, 5},
					{6, 6, 6, 6, 6, 6, 6, 6, 6},
					{7, 7, 7, 7, 7, 7, 7, 7, 7},
					{8, 8, 8, 8, 8, 8, 8, 8, 8},
					{9, 9, 9, 9, 9, 9, 9, 9, 9},
			};
			int[] arr3 = 
					{1, 2, 3, 4, 5, 6, 7, 8, 9};
		

			int i = 0;
			int j = 0;

			for(i = 0; i < a; i++){

				Console.Write(arr3[i] + " ");

				for(j = 0; j < b; j++){

					Console.Write(arr[i, j]  + "" + arr2[i, j] +  " " );
				}

				Console.Write('\n');
			}
			/*
			for(i = 0; i < a; i++){
				for(j = 0; j < b; j++){

					Console.Write(arr2[i,j]);
				}
				Console.Write('\n');
			}
   REG ADD HKLM\SOFTWARE\Policies\Google\Chrome /v IncognitoModeAvailability /t REG_DWORD /d 1
			*/
			
			Console.WriteLine("");
			Console.WriteLine("Press Enter to Exit!");
			Console.ReadLine();
		}
	}
}

