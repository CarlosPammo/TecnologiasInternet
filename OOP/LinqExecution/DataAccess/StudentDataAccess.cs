using LinqExecution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExecution.DataAccess
{
	public class StudentDataAccess
	{
		public List<Student> GetStudents()
		{
			return new List<Student>()
			{
				new Student
				{
					ID=1,
					Name = "Alvaro",
					Lastname = "Mejia",
					Birthdate = new DateTime(2002,4,2)
				},
				new Student
				{
					ID=2,
					Name = "Monica",
					Lastname = "Rodriguez",
					Birthdate=new DateTime(2002,4,9)
				},
				new Student
				{
					ID=3,
					Name = "Alvarado",
					Lastname = "Mejillones",
					Birthdate = new DateTime(2002,5,3)
				}
			};
		}

	}
}
