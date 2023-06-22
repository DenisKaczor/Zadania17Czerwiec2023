using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Boolean posortowana = false;
			int rozmiar = 6;
			int[] tablica = new int[rozmiar];
			Random rand = new Random();
			//tworzenie tablicy
			for (int i = 0; i <= 5; i++)
			{
				tablica[i] = rand.Next(9);
				Console.WriteLine(tablica[i]);
			}   
			//algorytm bąbelkowy
			while (posortowana==false)
			{
				posortowana=true;
				for (int i = 0; i <= 4; i++)
				{
					if (tablica[i] > tablica[i + 1])
					{
						int a = tablica[i];
						int b = tablica[i + 1];
						tablica[i] = b;
						tablica[i + 1] = a;
						posortowana=false;
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
