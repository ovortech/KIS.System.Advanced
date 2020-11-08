using KIS.System.Advanced.Domain.Entities;
using System.Collections.Generic;

namespace KIS.System.Advanced.Services.Interfaces
{
    public interface IProdutoService
    {
        List<Produto> GetAll();
        List<Produto> GetAllActive();
        List<Produto> GetAllInactive();
        void Save(Produto produto);
        Produto Get(int idProduto);
        void Delete(int idProduto);
        void Update(Produto produto);
    }
}
