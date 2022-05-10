using Generics.Core;
using Generics.Model;
using System.Linq;
using System;

namespace Generics
{
	class Program
	{
		static void Main(string[] args)
		{
			var registry = new Registry<Student>().Where(student => student.Id == "2");
			foreach (var current in registry)
			{
				Console.WriteLine(current);
			}

			Console.ReadKey();
		}
	}
}
