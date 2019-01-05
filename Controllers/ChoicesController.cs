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
    public class ChoicesController : Controller
    {
        private ConfigContext _context;


        public ChoicesController(ConfigContext context)
        {
            _context = context;
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var product = _context.Product;
            var parameter = _context.Parameter;
            var parametervalue = _context.ParameterValue;
                        var disalowedvalue = _context.DisallowedValue;
            var disallowedrule = _context.DisallowedRule;
            var disallowedparameter = _context.DisallowedParameter;

            var viewModel = new ViewAll

            {
            Products = product,
            Parameters = parameter,
            ParameterValues = parametervalue,
            DisallowedValues = disalowedvalue,
            DisallowedRules = disallowedrule,
            DisallowedParameters = disallowedparameter
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
