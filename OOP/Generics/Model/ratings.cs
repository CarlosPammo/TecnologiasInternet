using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Model
{
    public class ratings : IMyModel
    {
        public string Id { get; set; }
        public string IdStudent { get; set; }
        public string IdSubject { get; set; }
        public int grade { get; set; }
        public string Root()
        {
            return "Resources/Grades.txt";
        }

        public IMyModel ToModel(string str)
        {
            var array = str.Split('-');
            return new ratings
            {
                IdStudent = array[0],
                IdSubject = array[1],
                grade = int.Parse(array[2]),
            };
        }
    }
}
