using KIS.System.Advanced.Domain.Dto;
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
        void SaveAll(List<Comissao> comissoes);
        Comissao Get(int idComissao);
        List<ComissaoDto> GetDto(int idVendedor, DateTime dataInicio, DateTime dataFim);
        void Update(Comissao comissao);
    }
}
