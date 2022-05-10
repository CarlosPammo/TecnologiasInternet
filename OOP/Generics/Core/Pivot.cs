using Generics.Model;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Generics.Core
{
	public class Pivot<T> : IEnumerator<T> where T : IMyModel, new()
	{
		private readonly StreamReader reader;
		public T Current { get; set; }
		object IEnumerator.Current => this;

		public Pivot()
		{
			Current = new T();
			reader = new StreamReader(Current.Root());
		}

		public void Dispose()
		{
			reader.Dispose();
		}

		public bool MoveNext()
		{
			var line = reader.ReadLine();
			if (line != null)
			{
				Current = (T)Current.ToModel(line);
			}
			return line != null;
		}

		public void Reset()
		{
			reader.DiscardBufferedData();
		}
	}
}
