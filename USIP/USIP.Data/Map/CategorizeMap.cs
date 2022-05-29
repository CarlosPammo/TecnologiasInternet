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
    public class CategorizeMap : EntityTypeConfiguration<Categoryze>
    {
        public CategorizeMap(string schema)
        {
            ToTable("Categorize", schema);
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Id).HasColumnName("Id").IsRequired();
            Property(p => p.IdProduct).HasColumnName("IdProduct").IsRequired();
            Property(p => p.IdCategory).HasColumnName("IdCategory").IsRequired();

            HasRequired(p => p.Product).WithMany().HasForeignKey(p => p.IdProduct);
            HasRequired(p => p.Category).WithMany().HasForeignKey(p => p.IdCategory);
        }

    }
}
