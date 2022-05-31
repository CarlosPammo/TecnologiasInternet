using Generics.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics.Core
{
	public class Registry<T> : IEnumerable<T> where T : IMyModel, new()
	{
		public IEnumerator<T> GetEnumerator()
		{
			return new Pivot<T>();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
