using LinqExecution.Entities;
using System;

namespace LinqExecution
{
	/// <summary>
	/// Extension Methods
	/// </summary>
	public static class Utils
	{
		public static int GetAge(this Student student)
		{
			var today = DateTime.Now;
			return today.Year - student.Birthdate.Year;
		}
	}
}
