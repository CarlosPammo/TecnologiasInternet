using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USIP.Model.MyModel;

namespace USIP.Data.Map.MyMap
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
		public ProductMap(string schema)
		{
			ToTable("Producto", schema);
			HasKey(p => p.Id);
			Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(p => p.Id).HasColumnName("Llave").IsRequired();
			Property(p => p.IdBrand).HasColumnName("IdMarca").IsRequired();
			Property(p => p.IdCategory).HasColumnName("IdCategoria").IsRequired();

			HasRequired(p => p.Brand).WithMany().HasForeignKey(p => p.IdBrand);
			HasRequired(p => p.Category).WithMany().HasForeignKey(p => p.IdCategory);
		}
	}
}
