using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfigThis.Models;
using ConfigThis.NewFolder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConfigThis.Controllers
{
    public class ProductsController : Controller
    {
        private ConfigContext _context;


        public ProductsController(ConfigContext products)
        {
            _context = products;
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var prods = _context.Product;

            var viewModel = new ViewAll
            {
                Products = prods
            };

            return View(viewModel);
        }


        [Route("[controller]/[action]/{id}")]
        public IActionResult Details(int id)
        {
            var customer = _context.Product.SingleOrDefault(c => c.ObjectId == id);

            return View(customer);
        }
    }
}
