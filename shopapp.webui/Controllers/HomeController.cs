using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Models;

namespace shopapp.webui.Controllers
{
    public class HomeController : Controller//.netcore içinde var olan Controller clasını Homeconstroller clasına kalıttımki Homecontroller controller gibi hareket etsin
    {   
        public IActionResult Index()
        {
            var product = new List<Product>(){
           new Product{Name="Iphone 8", Price=3000,Description="İyi telefon",IsApproved=true},
           new Product{Name="Iphone X", Price=6000,Description="Güzel telefon",IsApproved=true},
           new Product{Name="Iphone 9", Price=6000,Description="Güzel telefon",IsApproved=false},
           new Product{Name="Iphone 10", Price=6000,Description="Güzel telefon"}
           };

           
        var productsViewModel = new ProductViewModel
        {
            Products = product
        };

            return View(productsViewModel);
        }
        public IActionResult Abouth()
        {
            return View();
        }
         public IActionResult Contact()
        {
            return View("MyView");//View("MyView") myviewi arar eğer boş bıraksaydık contactı arardı
        }
    }
}