using System;

namespace Prueba1
{
	class Program
	{
		static void Main(string[] args)
		{

			Rectangle rectangle1 = new Rectangle();
			rectangle1.basis = 3;
			rectangle1.height = 7;

			//rectangle1.Grow(10);

			Console.WriteLine(rectangle1.Area()); //Area
			Console.WriteLine(rectangle1.Perimetro()); //Perimetro


			Rectangle rectangle2 = new Rectangle();
			rectangle2.basis = 1.5;
			rectangle2.height = 4;

			Console.WriteLine(rectangle2.Area());   //Area
			Console.WriteLine(rectangle2.Perimetro()); //Perimetro

			Console.WriteLine(rectangle1.Compare(rectangle2)); //Comparacion y resto del area



			Console.ReadKey();

		}
	}
}
