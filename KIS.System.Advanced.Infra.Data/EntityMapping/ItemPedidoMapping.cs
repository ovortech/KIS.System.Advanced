using KIS.System.Advanced.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace KIS.System.Advanced.Infra.Data.EntityConfig
{
    public class ItemPedidoMapping : EntityTypeConfiguration<ItemPedido>
    {
        public ItemPedidoMapping()
        {
            ToTable("ITEM_PEDIDO");
            HasKey(e => e.ID_ITEM_PEDIDO);
            Property(e => e.ID_PEDIDO).IsRequired();  
            Property(e => e.ID_PRODUTO).IsRequired();
            Property(e => e.OBS_PRODUTO).HasMaxLength(50).IsRequired();
            Property(e => e.QTD_PEDIDO).IsRequired();
            Property(e => e.VALOR_UN_PEDIDO).IsRequired();
            Property(e => e.DESCONTO_PEDIDO).IsRequired();
            Property(e => e.ATIVO).IsRequired();
        }

    }
}
