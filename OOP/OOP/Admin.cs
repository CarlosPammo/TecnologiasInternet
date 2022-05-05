using System;

namespace OOP
{
	public class Admin : Person
	{
		public Admin(string name, string lastname)
			: base (name, lastname)
		{ }

		public override string ListYourWorkPlace()
		{
			return "Rectorado";
		}

		public override string GetActivities()
		{
			return "Administrar Operaciones en la universidad";
		}
	}
}
