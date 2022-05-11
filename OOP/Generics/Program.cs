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
			var subjects = new Registry<Subject>();
			var grades = new Registry<Grades>();

            var filtered =
                from student in students
                join grade in grades on student.Id equals grade.IdStudent
                join subject in subjects on grade.IdSubject equals subject.Id
                where subject.Name == "Calculo 1" && grade.grade >= 60
                select student;

            foreach (var current in filtered)
			{
				Console.WriteLine(current);
			}

			Console.ReadKey();
		}
	}
}
