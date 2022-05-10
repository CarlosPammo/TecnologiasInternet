using EntityAccess;
using EntityAccess.Context;
using EntityAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFESample
{
	class Program
	{
		static void Main(string[] args)
		{
			var repository = new Repository<Student>(new BaseContext());
			//repository.Insert(new Student
			//{
			//	Name = "Elias",
			//	Lastname = "Chavarria"
			//});

			Console.WriteLine(repository.Select(s => true).First().Name);

			Console.ReadKey();
		}
	}
}
