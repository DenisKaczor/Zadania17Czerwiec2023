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
			int rozmiar = 10;
			int[] tablica = new int[rozmiar];
			Random rand = new Random();
			for (int i = 0; i <= 9; i++)
			{
				tablica[i] = rand.Next(100);
				Console.WriteLine(tablica[i]);
			}
			Console.WriteLine("Teraz odwrotna kolejność");
			while(rozmiar>0)
			{
				rozmiar--;
				Console.WriteLine(tablica[rozmiar]);
			}
			Console.ReadLine();
		}
		
	}
}
