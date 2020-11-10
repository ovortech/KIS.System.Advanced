using KIS.System.Advanced.Business;
using KIS.System.Advanced.Domain.Dto;
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

        public List<ComissaoDto> GetDto(int idVendedor, DateTime dataInicio, DateTime dataFim)
        {
            return _comissaoBS.GetDto(idVendedor, dataInicio, dataFim);
        }

        public void Save(Comissao comissao)
        {
            _comissaoBS.Save(comissao);
        }

        public void SaveAll(List<Comissao> comissoes)
        {
            _comissaoBS.SaveAll(comissoes);
        }

        public void Update(Comissao comissao)
        {
            _comissaoBS.Update(comissao);
        }
    }
}
