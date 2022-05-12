using EntityAccess;
using EntityAccess.Context;
using EntityAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFESample
{
	class Program
	{



		static void Main(string[] args)
		{
			var repository = new Repository<Career>(new BaseContext());

			#region ==== Insert ====
			//repository.Insert(new Student
			//{
			//	Name = "Elias",
			//	Lastname = "Chavarria"
			//});
			#endregion

			#region ==== Update ====
			//var student = repository
			//	.Select(s => s.Name.Equals("Elias"))
			//	.First();

			//student.Name = "Elias Augusto";
			//repository.Update(student);
			#endregion

			#region ==== Delete ====
			//repository.Delete(s => s.Lastname.Equals("Chavarria"));
			#endregion

			foreach (var item in repository.Select(s => true))
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();
		}
	}
}
