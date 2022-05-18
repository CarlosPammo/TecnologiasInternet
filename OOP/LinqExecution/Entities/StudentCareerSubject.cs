using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExecution.Entities
{
    class StudentCareerSubject
    {
        public int Id { get; set; }
        public int IdSubject { get; set; }

        public int IdStudent { get; set; }
        public int IdCareer { get; set; }
    }
}
