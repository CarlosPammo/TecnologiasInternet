using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USIP.Model;

namespace USIP.Data.Map
{
	public class CategoryMap : EntityTypeConfiguration<Category>
	{
		public CategoryMap(string schema)
		{
			ToTable("Category", schema);
			HasKey(p => p.Id);
			Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(p => p.Id).HasColumnName("Id").IsRequired();
			Property(p => p.Name).HasColumnName("Name").IsRequired();
			Property(p => p.Description).HasColumnName("Description").IsRequired();

		}
	}
}
