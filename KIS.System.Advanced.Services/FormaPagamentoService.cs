using KIS.System.Advanced.Business;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services
{
    public class FormaPagamentoService : IFormaPagamentoService
    {
        private readonly FormaPgBS _formaPgBS;

        public FormaPagamentoService()
        {
            _formaPgBS = new FormaPgBS();
        }
        public List<FormaPg> GetAllByOrderId(int orderId)
        {
            return _formaPgBS.GetAllByOrderId(orderId);
        }
    }
}
