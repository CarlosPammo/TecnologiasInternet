using LinqExecution.DataAccess;
using System.Linq;
using System;

namespace LinqExecution
{
	class Program
	{
		static void Main(string[] args)
		{
			var students = new StudentDataAccess()
				.GetStudents();

			// Buscar a todos los estudiantes cuyo apellido empiece con A
			// Linq to Sql
			//var filtered =
			//	from student in students
			//	where student.Lastname.StartsWith("M")
			//	select student;

			// Extension Methods
			var filtered = students
				.Where(student => student.Lastname.StartsWith("M"));

			foreach (var student in filtered)
			{
				Console.WriteLine(student);
			}

			Console.ReadKey();
		}
	}
}
