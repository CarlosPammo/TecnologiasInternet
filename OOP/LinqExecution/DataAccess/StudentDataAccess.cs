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
					Name = "Alvaro",
					Lastname = "Mejia"
				},
				new Student
				{
					Name = "Monica",
					Lastname = "Rodriguez"
				}
			};
		}

	}
}
