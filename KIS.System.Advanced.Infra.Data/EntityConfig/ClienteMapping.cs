using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class ClienteMapping : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapping()
        {
            ToTable("CLIENTE");
            HasKey(e => e.ID_CLIENTE);
            Property(e => e.NOME_CLIENTE);  // IsRequired() não permitir nulo
        }
    }
}
