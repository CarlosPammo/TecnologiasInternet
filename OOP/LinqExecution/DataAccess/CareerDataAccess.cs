using LinqExecution.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExecution.DataAccess
{
	public class CareerDataAccess
	{
		public List<Career> GetCareeers()
		{
			return new List<Career>()
			{
				new Career
                {
					ID =1,
					Name="Ing. de Sistemas",
					Code="IS"
                },
				new Career
				{
					ID =2,
					Name="Ing. en Telecomunicaciones",
					Code="IT"
				}
			};
		}
	}
}
