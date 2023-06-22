using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int max=0;
			int min=99999999;
			int rozmiar = 10;
			int[] tablica = new int[rozmiar];
			Random rand = new Random();
			for (int i = 0; i <= 9; i++)
			{
				tablica[i] = rand.Next(100);
				Console.WriteLine(tablica[i]);
			}   //tworzenie tablicy
			for (int i = 0; i <= 9; i++)
			{
				if (tablica[i] >max)
				{
					max = tablica[i];
				}
				else if (tablica[i] <min)
				{
					min = tablica[i];
				}
			}

			Console.WriteLine("maksymalna liczba tablicy: " + max);
			Console.WriteLine("minimalna liczba tablicy: " + min);
			Console.ReadLine();
		}
	}
}
