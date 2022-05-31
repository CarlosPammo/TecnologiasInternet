namespace Interfaces
{
	public class Dog : ITalk, IEat
	{
		public string Eating()
		{
			return "Come del piso en su plato";
		}

		public string Speaking()
		{
			return "Braft";
		}
	}
}
