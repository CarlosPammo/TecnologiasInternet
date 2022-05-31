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
	public class ProductMap : EntityTypeConfiguration<Product>
	{
		public ProductMap(string schema)
		{
			ToTable("Product", schema);
			HasKey(p => p.Id);
			Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(p => p.Id).HasColumnName("Id").IsRequired();
			Property(p => p.Name).HasColumnName("Name").IsRequired();
			Property(p => p.Description).HasColumnName("Description").IsRequired();
			Property(p => p.Price).HasColumnName("Price").IsRequired();
			Property(p => p.Count).HasColumnName("Count").IsRequired();
			Property(p => p.IsSpecialOffert).HasColumnName("IsSpecialOffert").IsRequired();
			Property(p => p.ImageUrl).HasColumnName("ImageUrl").IsRequired();
			Property(p => p.CreatedAt).HasColumnName("CreatedAt").IsRequired();
			Property(p => p.IdCategory).HasColumnName("IdCategory").IsRequired();

			HasRequired(p => p.Category).WithMany().HasForeignKey(p => p.IdCategory);

		}
	}
}
