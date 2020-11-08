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
    public class TipoPagamentoService : ITipoPagamentoService
    {
        private TipoPgBS _tipoPagamentoBS;

        public TipoPagamentoService()
        {
            _tipoPagamentoBS = new TipoPgBS();
        }

        public void Delete(int idTipoPagamento)
        {
            _tipoPagamentoBS.Delete(idTipoPagamento);
        }

        public TipoPg Get(int idFormaPagamento)
        {
            return _tipoPagamentoBS.Get(idFormaPagamento);
        }

        public List<TipoPg> GetAll()
        {
            return _tipoPagamentoBS.GetAll();
        }

        public List<TipoPg> GetAllActive()
        {
            return _tipoPagamentoBS.GetAllActive();
        }

        public List<TipoPg> GetAllInactive()
        {
            return _tipoPagamentoBS.GetAllInactive();
        }

        public void Save(TipoPg tipoPagamento)
        {
            _tipoPagamentoBS.Save(tipoPagamento);
        }

        public void Update(TipoPg tipoPagamento)
        {
            _tipoPagamentoBS.Update(tipoPagamento);
        }
    }
}
