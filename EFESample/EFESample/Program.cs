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
			//var student = new Repository<Student>(new BaseContext());
			//var career = new Repository<Career>(new BaseContext());
			//var study = new Repository<Study>(new BaseContext());

			//var student1 = new Student
			//{
			//	Name = "Elias",
			//	Lastname = "Chavarria"
			//};
			//var student2 = new Student
			//{
			//	Name = "Brandon",
			//	Lastname = "Arenas"
			//};
			//var student3 = new Student
			//{
			//	Name = "Yurgen",
			//	Lastname = "Espinoza"
			//};
			//var career1 = new Career
			//{
			//	Name = "Ing. Sistemas",
			//	Code = "SIS"
			//};
			//var career2 = new Career
			//{
			//	Name = "Ing. Telecomunicaciones",
			//	Code = "TEL"
			//};

			//student.Insert(student1);
			//student.Insert(student2);
			//student.Insert(student3);

			//career.Insert(career1);
			//career.Insert(career2);

			//study.Insert(new Study
			//{
			//	Student = student1,
			//	Career = career1
			//});
			//study.Insert(new Study
			//{
			//	Student = student3,
			//	Career = career2
			//});


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

			var repository = new Repository<Student>(new BaseContext());
			// Linq to Sql
			var filtered =
				from student in repository.Context.Set<Student>()
				join study in repository.Context.Set<Study>() on student.Id equals study.IdStudent
				join career in repository.Context.Set<Career>() on study.IdCareer equals career.Id
				where career.Name == "Ing. Telecomunicaciones"
				select student;

			foreach (var item in filtered)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();
		}
	}
}
