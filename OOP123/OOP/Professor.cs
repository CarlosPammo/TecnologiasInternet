namespace OOP
{
	public class Professor : Person
	{
		public Professor(string name, string lastname)
			: base(name, lastname)
		{ }

		public override string GetActivities()
		{
			return "Ensenia";
		}
	}
}
