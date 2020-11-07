using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services.Interfaces
{
    public interface ITipoPagamentoService
    {
        List<TipoPg> GetAll();
        TipoPg Get(int idFormaPagamento);
        void Save(TipoPg tipoPagamento);
        void Delete(int idTipoPagamento);
        void Update(TipoPg tipoPagamento);
    }
}
