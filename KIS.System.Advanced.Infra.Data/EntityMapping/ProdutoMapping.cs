using KIS.System.Advanced.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class ProdutoMapping : EntityTypeConfiguration<Produto>
    {
        public ProdutoMapping()
        {
            ToTable("PRODUTO");
            HasKey(e => e.ID_PRODUTO);
            Property(e => e.NOME_PRODUTO).HasMaxLength(50).IsRequired();
            Property(e => e.SERVICO_PRODUTO).IsRequired();
            Property(e => e.VALOR_PRODUTO).IsRequired();
            Property(e => e.ATIVO).IsRequired();

        }

    }
}
