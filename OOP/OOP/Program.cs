using System;

namespace OOP
{
	class Program
	{
		static void Print(Person person)
		{
			Console.WriteLine($"{person}: {person.GetActivities()}. Trabajo en {person.ListYourWorkPlace()}");
		}

		static void Main(string[] args)
		{
			var person = new Professor("Carlos", "Pammo")
			{
				Birthday = new DateTime(1986, 3, 12)
			};

			Print(person);

			var student = new Student("Elias", "Chavaria")
			{
				Career = "Ing Sistemas"
			};

			Print(student);

			var admin = new Admin("Santiago", "Sologuren");

			Print(admin);

			Console.ReadKey();
		}
	}
}
