using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Systhem.Catalog.Api.Interfaces;
using Systhem.Catalog.Api.Models;

namespace Systhem.Catalog.Api.Controllers
{

    [ApiController]
    [Authorize]
    public class CatalogController : Controller
    {
        private readonly IProductRepository _produtoRepository;

        public CatalogController(IProductRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [AllowAnonymous]
        [HttpGet("catalogo/produtos")]
        public async Task<IEnumerable<Product>> Index()
        {
            return await _produtoRepository.ObterTodos();
        }

        //[ClaimsAuthorize("Catalogo", "Ler")]
        [HttpGet("catalogo/produtos/{id}")]
        public async Task<Product> ProdutoDetalhe(Guid id)
        {
            return await _produtoRepository.ObterPorId(id);
        }
    }
}

