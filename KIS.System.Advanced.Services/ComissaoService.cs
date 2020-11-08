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
    public class ComissaoService : IComissaoService
    {
        private readonly ComissaoBS _comissaoBS;

        public ComissaoService()
        {
            _comissaoBS = new ComissaoBS();
        }

        public Comissao Get(int idComissao)
        {
            return _comissaoBS.Get(idComissao);
        }

        public List<Comissao> GetAll()
        {
            return _comissaoBS.GetAll();
        }

        public void Save(Comissao comissao)
        {
            _comissaoBS.Save(comissao);
        }

        public void Update(Comissao comissao)
        {
            _comissaoBS.Update(comissao);
        }
    }
}
