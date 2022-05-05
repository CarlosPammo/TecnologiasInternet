namespace Interfaces
{
	public class Person : ITalk, IEat
	{
		public string Eating()
		{
			return "Me siento en la maso y me sirvo un plato";
		}

		public string Speaking()
		{
			return "Hola!!!!!";
		}
	}
}
