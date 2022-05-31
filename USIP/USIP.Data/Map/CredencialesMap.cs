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
    class CredencialesMap : EntityTypeConfiguration<Credentials>
    {
        public CredencialesMap(string schema)
        {
            ToTable("Credenciales", schema);
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Id).HasColumnName("Llave").IsRequired();
            Property(p => p.IdUser).HasColumnName("id usuario").IsRequired();
            Property(p => p.UserName).HasColumnName("usuario").IsRequired();
            Property(p => p.Password).HasColumnName("contrasena").IsRequired();
            Property(p => p.IdRol).HasColumnName("idRoles").IsRequired();//como se mapea el enumerador
          //  Property(p => p.Estate).HasColumnName("estado").IsRequired();
            HasRequired(p => p.User).WithMany().HasForeignKey(p => p.IdUser);
            HasRequired(p => p.RolMain).WithMany().HasForeignKey(p => p.IdRol);
        }
    }
}
