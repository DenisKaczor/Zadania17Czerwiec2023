using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5
{
	internal class Program
	{
		static void Main(string[] args)
		{
		
			int rozmiar = 6;
			int[] tablica = new int[rozmiar];
			Random rand = new Random();
			//tworzenie tablicy
			for (int i = 0; i <= 5; i++)
			{
				tablica[i] = rand.Next(9);
				Console.WriteLine(tablica[i]);
			}
			//algorytm sortujący przez wybieranie
			int min;
			int pozycjaZamiany;
			int podmieniana;
			for (int i = 0; i < 5; i++)
			{
				min = i;
				int licznik;
				licznik = i;
				pozycjaZamiany= licznik;
				podmieniana = tablica[licznik];
				if (min == tablica[licznik])
				{
					continue;
				}
				else
				{
					min = tablica[licznik];
				}
				
				while (licznik<5)
				{

					if (min > tablica[licznik+1])
					{
						min = tablica[licznik+1];
						pozycjaZamiany = licznik +1;
						licznik++;
						continue;
					}
					else
					{
						licznik++;
						continue;
					}
				}
				tablica[i] = min;
				tablica[pozycjaZamiany] = podmieniana;
			}
			//wyświetlanie
			Console.WriteLine("teraz posortowana");
			for (int i = 0; i <= 5; i++)
			{
				Console.WriteLine(tablica[i]);
			}
			Console.ReadKey();
		}
	}
	
}
