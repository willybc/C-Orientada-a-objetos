using System;

namespace Prueba1
{
	class Program
	{
		static void Main(string[] args)
		{
			Person pers = new Person("Willy", "Bardales");
			Person pers2 = new Person("Luis", "Pariona", 01, 06, 1997);
			Person pers3 = new Person();

			Console.WriteLine(pers.Age());
			Console.ReadKey();

		}
	}
}
