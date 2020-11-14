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
        void Save(Pedido produto);
        Pedido Get(int idProduto);
        void Delete(int idProduto);
        void Update(Pedido produto);
        void SaveNewOrder(Pedido pedido, List<ItemPedido> itensPedido, List<FormaPg> formasPagamento);
        //int GetNextOrderNumber();

    }
}
