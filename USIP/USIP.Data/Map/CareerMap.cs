using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using USIP.Model;

namespace USIP.Data.Map
{
	public class CareerMap : EntityTypeConfiguration<Career>
	{
		public CareerMap(string schema)
		{
			ToTable("Carrera", schema);
			HasKey(p => p.Id);
			Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(p => p.Id).HasColumnName("Llave").IsRequired();
			Property(p => p.Name).HasColumnName("Nombre").IsRequired();
			Property(p => p.Code).HasColumnName("Codigo").IsRequired();
		}
	}
}
