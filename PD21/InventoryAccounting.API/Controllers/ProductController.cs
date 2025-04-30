using InventoryAccounting.API.Data;
using InventoryAccounting.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryAccounting.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductId(int id)
        {
            return Ok(_context.Products.FirstOrDefault(p => p.Id == id));
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _context.Products.Add(product);

            _context.SaveChanges();

            return Ok(product);
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteProduct(int id)
        {

            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return NoContent();

        }
    }

    //[HttpGet(Name = "GetProduct")]
    //public IActionResult Index()
    //{
    //    return View();
    //}



}

