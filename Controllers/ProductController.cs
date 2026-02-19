

using Microsoft.AspNetCore.Mvc;
using Ecommerce.Data;
using Ecommerce.Models;
using System.Linq;

namespace Ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/product
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        // GET: api/product/1
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
                return NotFound("Product not found");

            return Ok(product);
        }

        // POST: api/product
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return Ok(product);
        }

        // PUT: api/product/1
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updatedProduct)
        {
            var product = _context.Products.Find(id);

            if (product == null)
                return NotFound("Product not found");

            product.Name = updatedProduct.Name;
            product.Description = updatedProduct.Description;
            product.Price = updatedProduct.Price;
            product.Stock = updatedProduct.Stock;

            _context.SaveChanges();

            return Ok(product);
        }

        // DELETE: api/product/1
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
                return NotFound("Product not found");

            _context.Products.Remove(product);
            _context.SaveChanges();

            return Ok("Product deleted successfully");
        }



        // GET: api/product/search?name=laptop
        [HttpGet("search")]
        public IActionResult SearchProduct(string name)
        {
            var products = _context.Products
                .Where(p => p.Name.Contains(name))
                .ToList();

            return Ok(products);
        }

    }
}

