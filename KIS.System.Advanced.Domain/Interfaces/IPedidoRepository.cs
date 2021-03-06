﻿using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Domain.Interfaces
{
    public interface IPedidoRepository : IRepositoryBase<Pedido>
    {
        int GetNextOrderNumber();
        int SaveNewOrder(Pedido pedido, List<ItemPedido> itensPedido, List<FormaPg> formasPagamento, bool cancelar = false);
        void UpdateFaturamento(int idPedido, bool faturado);
    }
}
