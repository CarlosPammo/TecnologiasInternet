using EntityAccess.Map;
using System.Data.Entity;

namespace EntityAccess.Context
{
	public class BaseContext : DbContext
	{
		private readonly string schema;

		public BaseContext()
			: base("name=SqlContext")
		{
			schema = "dbo";
			Database.SetInitializer(new CreateDatabaseIfNotExists<BaseContext>());
			SetConnectionString();
		}

		private void SetConnectionString()
		{
			Database.Connection.ConnectionString
				= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\TecnologiasInternet\EFESample\EFESample\Resources\MyDbSample.mdf;Integrated Security=True";
		}

		protected override void OnModelCreating(DbModelBuilder builder)
		{
			builder.Configurations.Add(new StudentMap(schema));
			builder.Configurations.Add(new CareerMap(schema));
			builder.Configurations.Add(new StudyMap(schema));
		}
	}
}
