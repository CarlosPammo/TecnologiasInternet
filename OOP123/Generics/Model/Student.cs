namespace Generics.Model
{
	public class Student : IMyModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Lastname { get; set; }

		public string Root()
		{
			return "Resources/Students.txt";
		}

		public IMyModel ToModel(string str)
		{
			var array = str.Split('-');
			return new Student
			{
				Id = array[0],
				Name = array[1],
				Lastname = array[2]
			};
		}

		public override string ToString()
		{
			return $"{Name} {Lastname}";
		}
	}
}
