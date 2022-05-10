namespace Generics.Model
{
	public class Career : IMyModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }

		public string Root()
		{
			return "Resources/Careers.txt";
		}

		public IMyModel ToModel(string str)
		{
			var array = str.Split('-');
			return new Career
			{
				Id = array[0],
				Name = array[1],
				Code = array[2]
			};
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
