using System;

namespace Prueba1
{
	class Program
	{
		static void Main(string[] args)
		{
			

			Person persona1 = new Person();
			persona1.Name = "Maria";
			persona1.Age = 21;

			Person persona2 = new Person();
			persona2.Name = "Antonio";
			persona2.Age = 22;

			Console.WriteLine($"persona 1 se llama {persona1.Name} y tiene {persona1.Age} años");
			Console.WriteLine($"persona 2 se llama {persona2.Name} y tiene {persona2.Age} años");

			Console.ReadKey();

		}
	}
}
