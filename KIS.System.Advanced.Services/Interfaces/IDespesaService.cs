using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services.Interfaces
{
    public interface IDespesaService
    {
        List<Despesa> GetAll();
        List<Despesa> GetAllActive();
        List<Despesa> GetAllInactive();
        void Save(Despesa despesa);
        Despesa Get(int IdDespesa);
        void Delete(int IdDespesa);
        void Update(Despesa despesa);
    }
}
