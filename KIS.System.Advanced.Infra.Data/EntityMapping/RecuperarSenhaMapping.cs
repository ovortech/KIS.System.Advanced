using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class RecuperarSenhaMapping : EntityTypeConfiguration<RecuperarSenha>
    {
        public RecuperarSenhaMapping()
        {
            ToTable("RECUPERAR_SENHA");
            HasKey(e => e.ID_RECUPERAR_SENHA);
            Property(e => e.ID_USUARIO).IsRequired(); // Verificar
            Property(e => e.PRIVATE_TOKEN).HasMaxLength(50).IsRequired();
            Property(e => e.ALTERADO_SENHA).IsRequired(); // Verificar
            Property(e => e.ATIVO).IsRequired(); // Verificar
        }
    }
}
