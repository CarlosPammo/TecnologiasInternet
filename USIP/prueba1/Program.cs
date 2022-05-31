using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USIP.Data;
using USIP.Model;

namespace prueba1
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new Repository<Student>(new USIP.Data.Context.BaseContext());
            repository.Select(s=> true);
          
        }
    }
}
