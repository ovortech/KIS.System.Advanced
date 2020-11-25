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
    public class DespesaService : IDespesaService
    {
        private readonly DespesaBS despesaBS;
        public DespesaService()
        {
            despesaBS = new DespesaBS();
        }

        public void Delete(int IdDespesa)
        {
            despesaBS.Delete(IdDespesa);
        }

        public Despesa Get(int IdDespesa)
        {
            return despesaBS.Get(IdDespesa);
        }

        public List<Despesa> GetAll()
        {
            return despesaBS.GetAll();
        }

        public List<Despesa> GetAllActive()
        {
            return despesaBS.GetAllActive();
        }

        public List<Despesa> GetAllInactive()
        {
            return despesaBS.GetAllInactive();
        }

        public void Save(Despesa despesa)
        {
            despesaBS.Save(despesa);
        }

        public void Update(Despesa despesa)
        {
            despesaBS.Update(despesa);
        }
    }
}
