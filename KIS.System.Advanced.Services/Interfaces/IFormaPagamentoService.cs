using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services.Interfaces
{
    public interface IFormaPagamentoService
    {
        List<FormaPg> GetAllByOrderId(int orderId);
    }
}
