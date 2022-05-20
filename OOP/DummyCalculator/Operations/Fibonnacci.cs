using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyCalculator.Operations
{
	public class Fibonnacci : IOperator
	{
		public int Index { get; set; }

		public int ExecuteOperation()
		{
			int previous = 0;
			int currentIndex = 1;
			int currentValue = 1;
			int next;
			int response = 0;
			do
			{
				//1,1,2,3,5,8,13
				if (Index == 1 || Index == 2)
				{
					response = 1;
				}
				else
				{
					next = previous + currentValue;
					previous = currentValue;
					currentValue = next;
				}
				currentIndex++;

				if (Index == currentIndex)
				{
					response = currentValue;
				}
			} while (response == 0);
			return response;
		}

		public void SetDataNumbers()
		{
			Console.WriteLine("Ingrese la posicion: ");
			Index = int.Parse(Console.ReadLine());
		}
	}
}
