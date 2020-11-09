using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using System.Collections.Generic;

namespace KIS.System.Advanced.Domain.Interfaces
{
    public interface IComissaoRepository : IRepositoryBase<Comissao>
    {
        List<ComissaoDto> GetDto();
        void Merge(Comissao comissao);
    }
}
