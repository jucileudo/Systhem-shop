using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Systhem.Catalog.Api.Models;
using Systhem.Core.Data;

namespace Systhem.Catalog.Api.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> ObterTodos();
        Task<Product> ObterPorId(Guid id);

        void Adicionar(Product product);
        void Atualizar(Product product);
    }
}
