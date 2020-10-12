﻿using KIS.System.Advanced.Domain.Entities;
using System.Collections.Generic;

namespace KIS.System.Advanced.Services.Interfaces
{
    public interface IProdutoService
    {
        List<Produto> GetAll();
        void Save(Produto produto);
        Produto Get(int idProduto);
    }
}
