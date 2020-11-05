using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class FormaPgMapping : EntityTypeConfiguration<FormaPg>
    {
        public FormaPgMapping()
        {
            ToTable("FORM_PG");
            HasKey(e => e.ID_FORM_PG);
            Property(e => e.ID_PEDIDO).IsRequired(); // VERIFICAR TIPO
            Property(e => e.ID_TIPO_PG).IsRequired(); // VERIFICAR TIPO
            Property(e => e.VALOR_FORM_PG).IsRequired(); // VERIFICAR TIPO
            Property(e => e.ATIVO).IsRequired(); 
        }
    }
}
