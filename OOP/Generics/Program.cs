using Generics.Core;
using Generics.Model;
using System.Linq;
using System;

namespace Generics
{
	class Program
	{
		static void Main(string[] args)
		{
			var students = new Registry<Student>();
			var careers = new Registry<Career>();
			var studies = new Registry<Study>();

            var filtered =
                from student in students
                join study in studies on student.Id equals study.IdStudent
                join career in careers on study.IdCareer equals career.Id
                where career.Name == "Ing. Sistemas"
                select student;

            foreach (var current in filtered)
			{
				Console.WriteLine(current);
			}

			Console.ReadKey();
		}
	}
}
