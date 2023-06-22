using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace zadanie4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//pobieranie prawidłowej wysokości
			Console.WriteLine("Jak wysoki ma być twój romb?");
			int wysokosc = int.Parse(Console.ReadLine());
			for(int i = 0; i<3; i++)
			{
				if (wysokosc >= 3 & wysokosc%2>0)
				{
					break;
				}
				else if (i == 2)
				{
					Environment.Exit(0);
				}
				Console.WriteLine("Wprowadź poprawną wartość -  wysokosc >= 3 i nieparzysta");
				wysokosc = int.Parse(Console.ReadLine());
			}

			//przypisywanie zmiennych
			int iloscZnakowWWierszu = (2 * wysokosc) - 1;
			int spacja = iloscZnakowWWierszu - 1;
			int znak = 1;
			string wew = "";
			string zew = "";

			//losowanie znaku
			Random random = new Random();
			int wylosowanyZnak = random.Next(1, 5);
			if(wylosowanyZnak == 1)
			{
				wew = ".";
				zew = "#";
			}
			else if (wylosowanyZnak == 2)
			{
				wew = ":";
				zew = "@";
			}
			else if (wylosowanyZnak == 3)
			{
				wew = "-";
				zew = "|";
			}
			else if (wylosowanyZnak == 4)
			{
				wew = "+";
				zew = "*";
			}


			//pierwsza linia
			for (int j = 0; j < (spacja / 2)+1; j++)
			{
				Console.Write(" ");
			}
			Console.Write(zew);
			Console.WriteLine();


			//góra rombu
			for (int i = 0; i != (wysokosc/2)-1; i++)
			{
				for (int j = 0; j < spacja / 2; j++)
				{
					Console.Write(" ");
				}
				Console.Write(zew);
				for (int j = 0; j < znak; j++)
				{
					Console.Write(wew);
				}
				Console.Write(zew);

				znak += 2;
				spacja -= 2;
				Console.WriteLine();
			}

			//dół rombu
			for (int i = 0; i != (wysokosc / 2); i++)
			{
				for (int j = 0; j < spacja / 2; j++)
				{
					Console.Write(" ");
				}
				Console.Write(zew);
				for (int j = 0; j < znak; j++)
				{
					Console.Write(wew);
				}
				Console.Write(zew);

				znak -= 2;
				spacja += 2;
				Console.WriteLine();
			}

			//ostatnia linia
			for (int j = 0; j < (spacja / 2); j++)
			{
				Console.Write(" ");
			}
			Console.Write(zew);
			Console.WriteLine();


			Console.ReadKey();
		}
	}
}
