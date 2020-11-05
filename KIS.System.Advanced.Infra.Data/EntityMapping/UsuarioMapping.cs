using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {
            ToTable("Usuario");

            HasKey(e => e.ID_USUARIO);

            Property(e => e.LOGIN_USUARIO).HasMaxLength(50).IsRequired();
            Property(e => e.SENHA_USUARIO).HasMaxLength(10).IsRequired();
            Property(e => e.ID_TIPO_ACESSO_USUARIO).IsRequired();
            Property(e => e.NOME_USUARIO).HasMaxLength(50).IsRequired();
            Property(e => e.EMAIL_USUARIO).HasMaxLength(50).IsRequired();
            Property(e => e.ID_FUNCAO_USUARIO).IsRequired();
            Property(e => e.ATIVO).IsRequired();
        }
    }
}
