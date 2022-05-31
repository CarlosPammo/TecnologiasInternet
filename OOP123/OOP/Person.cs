using System;

namespace OOP
{
	public abstract class Person
	{
		public string Name { get; set; }
		public string Lastname { get; set; }
		public DateTime Birthday { get; set; }

		protected Person(string name, string lastname)
		{
			Name = name;
			Lastname = lastname;
		}

		public virtual string ListYourWorkPlace()
		{
			return "Aula";
		}

		public abstract string GetActivities();

		public override string ToString()
		{
			return $"{Name} {Lastname}";
		}
	}
}
