using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using System;
using System.Collections.Generic;

namespace KIS.System.Advanced.Domain.Interfaces
{
    public interface IComissaoRepository : IRepositoryBase<Comissao>
    {
        List<ComissaoDto> GetDto(int idVendedor, DateTime dataInicio, DateTime dataFim);
        void Merge(Comissao comissao);
    }
}
