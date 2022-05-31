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
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BaseContext>());
            SetConnectionString();
		}

		private void SetConnectionString()
		{
			Database.Connection.ConnectionString
				= @"data source=Elias-PC;Initial Catalog=Usip_elias2;Integrated Security=True;";
        }   

        protected override void OnModelCreating(DbModelBuilder builder)
		{
			builder.Configurations.Add(new StudentMap(schema));
			builder.Configurations.Add(new UserMap(schema));
			builder.Configurations.Add(new StudyMap(schema));
            builder.Configurations.Add(new CredencialesMap(schema));
            builder.Configurations.Add(new RolMap(schema));
            //builder.Configurations.Add(new RolMap(schema));

        }
	}
}
