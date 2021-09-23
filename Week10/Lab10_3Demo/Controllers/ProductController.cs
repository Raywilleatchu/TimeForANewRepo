using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab10_3Demo.Models;

namespace Lab10_3Demo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListProducts(string catId)
        {
            CategoryProducts cp = DAL.GetAllForCategory(catId);
            return View(cp);
        }

        public IActionResult IncreasePrice(int prodid)
        {
            Product prod = DAL.GetProduct(prodid);
            prod.price++;
            DAL.UpdateProduct(prod);
            return Redirect($"/Product/ListProducts?catid={prod.categoryId}");
        }

        public IActionResult DecreasePrice(int prodid)
        {
            Product prod = DAL.GetProduct(prodid);
            prod.price--;
            DAL.UpdateProduct(prod);
            return Redirect($"/Product/ListProducts?catid={prod.categoryId}");
        }
    }
}
