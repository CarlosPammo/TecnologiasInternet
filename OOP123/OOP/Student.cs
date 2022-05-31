namespace OOP
{
	public class Student : Person
	{
		public string Career { get; set; }

		public Student(string name, string lastname)
			: base(name, lastname)
		{ }

		public override string GetActivities()
		{
			return "Estudia";
		}
	}
}
