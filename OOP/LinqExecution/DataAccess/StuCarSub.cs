using LinqExecution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExecution.DataAccess
{
    class StuCarSub
    {
		public List<StudentCareerSubject> GetStuCarSub()
		{
			return new List<StudentCareerSubject>()
			{
				new StudentCareerSubject
				{
					IdCareer=1,
					IdStudent=2,
					IdSubject=1
				},
				new StudentCareerSubject
				{
					IdCareer=2,
					IdStudent=1,
					IdSubject=2
				},
				new StudentCareerSubject
				{
					IdCareer=2,
					IdStudent=3,
					IdSubject=2
				}
			};
		}
	}
}
