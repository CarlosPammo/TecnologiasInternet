using System;

namespace Interfaces
{
	class Program
	{
		public static void PrintEat(IEat eater)
		{
			Console.WriteLine(eater.Eating());
		}

		public static void PrintTalk(ITalk talker)
		{
			Console.WriteLine(talker.Speaking());
		}

		static void Main(string[] args)
		{
			var person = new Person();
			var dog = new Dog();

			PrintEat(person);
			PrintTalk(person);

			PrintEat(dog);
			PrintTalk(dog);

			Console.ReadKey();
		}
	}
}

