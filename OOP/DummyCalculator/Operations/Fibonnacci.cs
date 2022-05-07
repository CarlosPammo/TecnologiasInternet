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
			int last = 1;
			int current = 1;
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
					int previous = last;
					last = last + previous;
				}
				current++;

				if (Index == current)
				{
					response = last;
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
