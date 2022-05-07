namespace LinqExecution.Entities
{
	public class Student
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Lastname { get; set; }
		public string Birthdate { get; set; }

		public override string ToString()
		{
			return $"{Name} {Lastname}";
		}
	}
}
