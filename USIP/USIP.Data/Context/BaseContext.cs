using System.Data.Entity;
using USIP.Data.Map;

namespace USIP.Data.Context
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
				= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\Desktop\final\TecnologiasInternet\USIP\USIP\App_Data\USIP.mdf;Integrated Security=True";
		}

		protected override void OnModelCreating(DbModelBuilder builder)
		{
			builder.Configurations.Add(new StudentMap(schema));
			builder.Configurations.Add(new CareerMap(schema));
			builder.Configurations.Add(new StudyMap(schema));
			builder.Configurations.Add(new CategoryMap(schema));
			builder.Configurations.Add(new ProductMap(schema));
		}
	}
}
