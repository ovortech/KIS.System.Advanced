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
    public class TipoDespesaService : ITipoDespesaService
    {
        private readonly TipoDespesaBS tipoDespesaBS;
        public TipoDespesaService()
        {
            tipoDespesaBS = new TipoDespesaBS();
        }

        public List<TipoDespesa> GetAll()
        {
            return tipoDespesaBS.GetAll();
        }

        public List<TipoDespesa> GetAllActive()
        {
            return tipoDespesaBS.GetAllActive();
        }
    }
}
