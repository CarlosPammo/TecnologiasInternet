using LinqExecution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExecution.DataAccess
{
	public class StudyDataAccess
	{
		public List<Study> GetStudies()
		{
			return new List<Study>()
			{
				new Study
                {
					IdCareer=1,
					IdStudent=2
                },
				new Study
				{
					IdCareer=2,
					IdStudent=1
				}
			};
		}
	}
}
