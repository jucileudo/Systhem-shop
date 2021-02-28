using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Systhem.Catalog.Api.Interfaces;
using Systhem.Catalog.Api.Models;
using Systhem.Core.Data;

namespace Systhem.Catalog.Api.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly CatalogContext _context;

        public ProductRepository(CatalogContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => (IUnitOfWork)_context;

        public async Task<IEnumerable<Product>> ObterTodos()
        {
            return await _context.Products.AsNoTracking().ToListAsync();
        }

        public async Task<Product> ObterPorId(Guid id)
        {
            return await _context.Products.FindAsync(id);
        }

        public void Adicionar(Product product)
        {
            _context.Products.Add(product);
        }

        public void Atualizar(Product product)
        {
            _context.Products.Update(product);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
