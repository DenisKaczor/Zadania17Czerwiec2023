using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int j;
			int rozmiar = 6;
			int[] tablica = new int[rozmiar];
			Random rand = new Random();
			//tworzenie tablicy
			for (int i = 0; i <= 5; i++)
			{
				tablica[i] = rand.Next(9);
				Console.WriteLine(tablica[i]);
			}
			//algorytm sortujący przez wstawianie
			int z;
			for(z = 5; z!=0; z--)

			{ 
				j = 6;
				j -=z;
				while (j != 0)
				{
					if (tablica[j] < tablica[j-1])
					{
						int a = tablica[j];
						int b = tablica[j - 1];
						tablica[j] = b;
						tablica[j - 1]	= a;
						j--;
						continue;
					}
					else
					{
						break;
					}
				}
			}
			//wynik
			Console.WriteLine("teraz posortowana");
			for (int i = 0; i <= 5; i++)
			{
				Console.WriteLine(tablica[i]);
			}
			Console.ReadKey();
		}
	}
}
