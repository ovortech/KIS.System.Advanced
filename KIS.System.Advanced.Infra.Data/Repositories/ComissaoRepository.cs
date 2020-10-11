using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace KIS.System.Advanced.Infra.Data.Repositories
{
    public class ComissaoRepository : RepositoryBase<Comissao>, IComissaoRepository
    {
        public ComissaoRepository() : base()
        {

        }
      
    }
}
