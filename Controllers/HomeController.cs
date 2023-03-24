using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Strategy_Pattern.Interfaces;
using Strategy_Pattern.Strategies;

namespace Strategy_Pattern.Properties.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShippingContext _shippingContext;

        public HomeController(IShippingContext shippingContext)
        {
            _shippingContext = shippingContext;
        }

        public IActionResult Index()
        {
            var model = GetOrderDetails();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(CheckoutModel model)
        {
            model.ShippingMethods = GetShippingMethods();

            switch (model.SelectedMethod)
            {
                case 1:
                    _shippingContext.SetStrategy(new FreeShippingStrategy());
                    break;
                case 2:
                    _shippingContext.SetStrategy(new LocalShippingStrategy());
                    break;
                case 3:
                    _shippingContext.SetStrategy(new WorldwideShippingStrategy());
                    break;
            }

            model.FinalTotal = _shippingContext.ExecuteStrategy(model.OrderTotal);

            return View(model);
        }


        private CheckoutModel GetOrderDetails()
        {
            var model = new CheckoutModel()
            {
                OrderTotal = 0.00m,
                ShippingMethods = GetShippingMethods()
            };
            return model;
        }

        private List<ShippingMethod> GetShippingMethods()
        {
            return new List<ShippingMethod>()
        {
            new ShippingMethod()
            {
                Id = 1,
                Name="Free Shipping ($0.00)"
            },
            new ShippingMethod() {
                Id = 2,
                Name="Local Shipping ($10.00)"
            },
            new ShippingMethod() {
                Id = 3,
                Name="Worldwide Shipping ($50.00)"
            }
        };
        }
    }



}
