using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Model
{
    class Subject : IMyModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Root()
        {
            return "Resources/Subjects.txt";
        }

        public IMyModel ToModel(string str)
        {
            var array = str.Split('-');
            return new Subject
            {
                Id = array[0],
                Name = array[1],
            };
        }
    }
}
