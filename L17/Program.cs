﻿using System;
				
				if(att < explosion) {
				Console.Write("Enter the bomb code: ");
				Code = Console.ReadLine();
				att++;									

				}else{									
					defused = false;	
				}

			}while(Code != KeyCode && defused == true);			

				Console.WriteLine("Counter-terrorist Win!");
			}
			else{

				Console.WriteLine("Terrorist Win!");
			}
			Console.WriteLine("");
			Console.WriteLine("Press Enter to Exit!");
			Console.ReadLine();