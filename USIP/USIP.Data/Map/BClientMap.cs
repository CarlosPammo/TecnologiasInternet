using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using USIP.Model;

namespace USIP.Data.Map
{
    public class BClientMap:EntityTypeConfiguration<BClient>
    {
        public BClientMap(string schema)
        {
            ToTable("Client", schema);
            HasKey(x => x.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Id).HasColumnName("Key").IsRequired();
            Property(p => p.FName).HasColumnName("First Name").IsRequired();
            Property(p => p.LName).HasColumnName("Last Name").IsRequired();
            Property(p => p.Email).HasColumnName("Email").IsRequired();
            Property(p => p.Phone).HasColumnName("Phone").IsRequired();
            Property(p => p.Address).HasColumnName("Address").IsRequired();

        }
	}
}
