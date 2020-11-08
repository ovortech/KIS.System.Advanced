using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIS.System.Advanced.Services.Interfaces
{
    public interface IComissaoService
    {
        List<Comissao> GetAll();
        void Save(Comissao comissao);
        Comissao Get(int idComissao);
        void Update(Comissao comissao);
    }
}
