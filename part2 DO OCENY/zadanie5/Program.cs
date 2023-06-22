using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace zadanie5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//przyjmowanie wartości
			Console.WriteLine("obliczymy działanie y=x^n");
			Console.WriteLine("podaj liczbę x");
			int x = int.Parse(Console.ReadLine());
			while (x <= 0 || x > 9)
			{
				Console.WriteLine("podaj liczbę x");
				x = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("podaj liczbę n");
			int n = int.Parse(Console.ReadLine());
			while (n < 0)
			{
				Console.WriteLine("podaj liczbę n");
				n = int.Parse(Console.ReadLine());
			}

			// wstępne zmienne
			int wynikMnozenia = 0;
			int y = x;

			//program
			for (int i = 0; i < n-1; i++) 
			{
				wynikMnozenia = y;
				for(int j = 0; j < x-1; j++) 
				{
					y += wynikMnozenia;
				}
			}

			//wynik&porównanie
			double funkcjaMatematyczna = Math.Pow(x, n);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Wynik z programu dodającego: "+y);
			Console.WriteLine("Wynik z funkcji matematycznej: " + funkcjaMatematyczna);
			if(y== funkcjaMatematyczna)
			{
				Console.WriteLine("Wyniki są takie same");
			}
			else
			{
				Console.WriteLine("Wyniki są różne");
			}

			Console.ReadKey();
		}
	}
}
