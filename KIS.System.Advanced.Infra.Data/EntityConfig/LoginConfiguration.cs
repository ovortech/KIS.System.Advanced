using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class LoginConfiguration : EntityTypeConfiguration<Login>
    {
        public LoginConfiguration()
        {
            ToTable("Login");
            
            HasKey(p => p.LoginId);

            Property(p => p.UserName).IsRequired();
            Property(p => p.Password).IsRequired();
            //Property(p => p.UsuarioId).IsRequired();
        }
    }
}
