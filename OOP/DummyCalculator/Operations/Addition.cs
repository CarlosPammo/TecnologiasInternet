using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyCalculator.Operations
{
	public class Addition : IOperator
	{
		private int Number1 { get; set; }
		private int Number2 { get; set; }

		public int ExecuteOperation()
		{
			return Number1 + Number2;
		}

		public void SetDataNumbers()
		{
			Console.WriteLine("Ingresa el numero 1:");
			Number1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Ingresa el numero 2:");
			Number2 = int.Parse(Console.ReadLine()); 
		}
	}
}
