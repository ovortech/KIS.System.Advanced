using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services.Interfaces
{
    public interface IPedidoService
    {
        List<Pedido> GetAll();
        void Save(Pedido pedido);
        Pedido Get(int idPedido);
        void Delete(int idPedido);
        void Update(Pedido pedido);
        void SaveNewOrder(Pedido pedido, List<ItemPedido> itensPedido, List<FormaPg> formasPagamento, bool cancelar = false);

    }
}
