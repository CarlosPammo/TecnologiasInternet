using LinqExecution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExecution.DataAccess
{
    class SubjectDataAccess
    {
		public List<Subject> GetSubject()
		{
			return new List<Subject>()
			{
				new Subject
				{
					ID =1,
					Name="Calculo I",
					
				},
				new Subject
				{
					ID =2,
					Name="Algebra I",
					
				}
			};
		}
	}
}
