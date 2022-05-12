namespace EntityAccess.Model
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Lastname { get; set; }

		public override string ToString()
		{
			return $"{Name} {Lastname}";
		}
	}
}
