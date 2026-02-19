using Microsoft.AspNetCore.Mvc;
using Ecommerce.Data;
using Ecommerce.Models;
using System.Linq;

namespace Ecommerce.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/order
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var orders = _context.Orders.ToList();
            return Ok(orders);
        }

        // POST: api/order
        [HttpPost]
        public IActionResult PlaceOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();

            return Ok("Order placed successfully");
        }
    }
}
