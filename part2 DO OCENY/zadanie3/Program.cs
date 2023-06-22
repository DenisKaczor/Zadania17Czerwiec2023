using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int wysokosc = int.Parse(Console.ReadLine());
			int iloscZnakowWWierszu = (2 * wysokosc) - 1;
			int spacja = iloscZnakowWWierszu - 1;
			int znak = 1;
			for (int i = 0; i != wysokosc; i++)
			{
				for(int j = 0; j < spacja/2; j++)
				{
					Console.Write(" ");
				}
				for (int j = 0; j < znak; j++)
				{
					Console.Write("+");
				}

				znak += 2;
				spacja -= 2;
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}
