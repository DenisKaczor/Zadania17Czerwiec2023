using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			
			int liczbaWierszy = int.Parse(Console.ReadLine());
			int zapisaneWiersze = 0;
			for(int i = 2; zapisaneWiersze<liczbaWierszy; i++)
			{
				Boolean sprawdz = CzyPierwsza(i);
				if (sprawdz == true)
				{
					Console.WriteLine(i);
					zapisaneWiersze++;
				}
				else
				{
					continue;					
				}
			}


			Console.ReadKey();
		}
		
		static Boolean CzyPierwsza(int i)
		{
			int j = 2;
			while (j!=i)
			{
				if(i%j==0)
				{
					return false;
				}
				else if(j%i!=0) 
				{
					j++;
					continue;
					
				}
				
			}
			return true;
		}
	}
}
