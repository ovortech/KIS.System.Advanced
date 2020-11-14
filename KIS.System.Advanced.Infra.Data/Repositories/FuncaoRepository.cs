using KIS.System.Advanced.Domain.Dto;
using KIS.System.Advanced.Domain.Entities;
using KIS.System.Advanced.Domain.Interfaces;
using KIS.System.Advanced.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;


namespace KIS.System.Advanced.Infra.Data.Repositories
{
    
    public class FuncaoRepository : RepositoryBase<Funcao>, IFuncaoRepository
    {
        public FuncaoRepository(ProjetoDataContext db = null) : base(db)
        {

        }

    }
}
