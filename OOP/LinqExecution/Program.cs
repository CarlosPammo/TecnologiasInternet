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
			var studies = new StudyDataAccess()
				.GetStudies();
			var careers = new CareerDataAccess()
				.GetCareeers();

            // Buscar a todos los estudiantes cuyo apellido empiece con A
            // Linq to Sql
            //var filtered =
            //	from student in students
            //	where student.Lastname.StartsWith("M")
            //	select student;

            // Extension Methods
            //var filtered = students
            //	.Where(student => student.Lastname.StartsWith("M"));


            // Linq to Sql
            //var filtered =
            //	from student in students
            //	join study in studies on student.ID equals study.IdStudent
            //	join career in careers on study.IdCareer equals career.ID
            //	where career.Name == "Ing. Sistemas"
            //	select student;

            var filtered =
                from student in students
                join study in studies on student.ID equals study.IdStudent
                join career in careers on study.IdCareer equals career.ID
                where career.Name == "Ing. Sistemas" && student.Birthdate.Month==4

                select student;

            //*******************************
            //Extension Methods

            /*
			var filtered = students
				.Join(studies,
					student => student.ID,
					study => study.IdStudent,
					(student, study) => new
					{
						student,
						study.IdCareer
					})
				.Join(careers,
					mixed => mixed.IdCareer,
					career => career.ID,
					(mixed, career) => new
					{
						mixed.student,
						career
					})
				.Where(joined => joined.career.Name == "Ing. Sistemas")
				.Select(joined => joined.student);
			*/
            //*****************************************



            foreach (var student in filtered)
			{
				Console.WriteLine(student);
			}

			Console.ReadKey();
		}
	}
}
