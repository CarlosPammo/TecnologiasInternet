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
    class RolMap : EntityTypeConfiguration<RolMain>
    {
        public RolMap(string schema)
        {
            ToTable("Roles", schema);
            HasKey(p => p.IdRol);
            Property(p => p.IdRol).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.IdRol).HasColumnName("Llave").IsRequired();
            Property(p => p.RolName).HasColumnName("nombre").IsRequired();
            Property(p => p.student).HasColumnName("rolstudent").IsRequired();
            Property(p => p.rectory).HasColumnName("rolrectory").IsRequired();
            Property(p => p.marketing).HasColumnName("rolmarketing").IsRequired();
            Property(p => p.administrator).HasColumnName("roladm").IsRequired();

           
        }
    }
    
}
