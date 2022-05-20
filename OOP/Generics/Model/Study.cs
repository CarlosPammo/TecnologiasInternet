using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Model
{
    public class Study : IMyModel
    {
        public string ID { get; set; }
        public string IdStudent { get; set; }
        public string IdCareer { get; set; }
        public string Root()
        {
            return "Resources/Study.txt";
        }

        public IMyModel ToModel(string str)
        {
            var array = str.Split('-');
            return new Study
            {
                ID = array[0],
                IdStudent = array[1],
                IdCareer = array[2]
            };
        }
    }
}
