using EntityAccess.Context;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace EntityAccess
{
	public class Repository<T> : IDisposable where T : class, new()
	{
		public BaseContext Context { get; set; }

		public Repository(BaseContext context)
		{
			Context = context;
		}

		public void Dispose()
		{
			if (Context != null)
			{
				Context.Dispose();
			}
		}

		public T Insert(T entity)
		{
			var entry = Context.Set<T>().Add(entity);
			Context.SaveChanges();
			return entry;
		}

		public IQueryable<T> Select(Expression<Func<T, bool>> lambda)
		{
			lambda.Compile();
			return Context.Set<T>().Where(lambda).AsQueryable();
		}
	}
}
