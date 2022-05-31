namespace DummyCalculator
{
	public class Operation
	{
		private readonly IOperator mathOperator;

		public Operation(IOperator mathOperator)
		{
			this.mathOperator = mathOperator;
		}

		public int ExecuteOperation()
		{
			mathOperator.SetDataNumbers();
			return mathOperator.ExecuteOperation();
		}
	}
}
