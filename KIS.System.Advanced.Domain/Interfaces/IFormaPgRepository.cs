using KIS.System.Advanced.Domain.Entities;
using System.Collections.Generic;

namespace KIS.System.Advanced.Domain.Interfaces
{
    public interface IFormaPgRepository : IRepositoryBase<FormaPg>
    {
        List<FormaPg> GetAllByOrderId(int orderId);
    }


}
