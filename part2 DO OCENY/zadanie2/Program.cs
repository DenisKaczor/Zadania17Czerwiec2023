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
			Console.WriteLine("ile wypisać liczb?");
			int liczbaPowtorzen = int.Parse(Console.ReadLine());
			Console.WriteLine("wybierz wersję programu - 1 czy 2?");
			int wersjaProgramu = int.Parse(Console.ReadLine());
			if(wersjaProgramu == 1)
			{
				for (int i = 0; i < liczbaPowtorzen; i++)
				{
					
					int a = LosujLiczbe();
					
					while (a%2 != 0)
						{
							a = LosujLiczbe();
							
					}
					Console.WriteLine(a);
					
				}
				Console.ReadKey(); 

			}
			else if(wersjaProgramu == 2)
			{
				

				for (int i = 0; i < liczbaPowtorzen; i++)
				{
					
					int a = LosujParzysta();
					Console.WriteLine(a);
				}
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("wybierz prawidłową wersję programu!");
			}
		}
		static int LosujParzysta()
		{
			Random rnd = new Random(Guid.NewGuid().GetHashCode());
			int a = rnd.Next(-9, 9);
			while (a%2!=0)
			{
				a = rnd.Next(-9, 9);
			}
			return a;
		}
		static int LosujLiczbe()
		{
			Random rnd = new Random(Guid.NewGuid().GetHashCode());
			int a = rnd.Next(-9, 9);
			return a;
		}
		
	}
}
