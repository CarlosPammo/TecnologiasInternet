using DummyCalculator.Operations;
using System;

namespace DummyCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			var operation = new Operation(new Addition());

			Console.WriteLine(operation.ExecuteOperation());

			Console.ReadKey();
		}
	}
}
