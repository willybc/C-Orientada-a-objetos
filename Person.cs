using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1
{
	public class Person
	{
		public string Name;
		public string surname;

		// Fecha de nacimiento
		public int birthDateDay;
		public int birthDateMonth;
		public int birthDateYear;

		//Constructores

		public Person()
		{

		}

		public Person(string name, string surname)
		{
			this.Name = name;
			this.surname = surname;
		}

		public Person(string name, string surname, int birthDateDay, int birthDateMonth, int birthDateYear)
		{
			this.Name = name;
			this.surname = surname;
			this.birthDateDay = birthDateDay;
			this.birthDateMonth = birthDateMonth;
			this.birthDateYear = birthDateYear;
		}

		public int Age()
		{
			int actualYear = DateTime.Now.Year;
			return actualYear - birthDateYear;
		}

	}
}
