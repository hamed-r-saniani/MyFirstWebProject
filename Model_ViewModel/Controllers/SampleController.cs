using Microsoft.AspNetCore.Mvc;
using Model_ViewModel.Models;
using Model_ViewModel.Models.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace Model_ViewModel.Controllers
{
    public class SampleController : Controller
    {
        private readonly IDatabaseContext _context;

        public SampleController(IDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            List<Product> Products;
            Category category = new Category();
            var categories = _context.Category.ToList();

            Products = _context.Product.ToList();

            if (id != null)
            {
                Products = Products.Where(p => p.ProductCategoryID == id).ToList();
            }


            SampleIndexViewModel ViewModel = new SampleIndexViewModel(Products, categories);


            return View(ViewModel);
        }
        public IActionResult Details(int id)
        {
            Product product = new Product();
            Category category = new Category();


            var Categories = _context.Category.ToList();
            var Products = _context.Product.ToList().Where(p => p.ProductID == id).First();


            SampleDetailsViewModel ViewModel = new SampleDetailsViewModel(Products, Categories);


            return View(ViewModel);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Title1 = "درباره";
            ViewBag.Desc1 = "از 6 سالگی پای کامپیوتر بزرگ شدم و تقریبا 90 درصد چیزهایی که از کامپیوتر بلدم رو خودآموز یاد گرفتم. آدم بسیار مهربون و دقیقی هستم و عاشق طبیعت و حیوانات.";


            ViewBag.Title2 = "تحصیلات";
            ViewBag.Desc2 = "دبیرستان رو در یکی از بهترین دبیرستان های منطقه گذروندم و سال 96 وارد دانشگاه شدم و در حال حاضر در رشته ی مهندسی کامپویتر مشغول به تحصیل هستم.";


            ViewBag.Desc3 = "در دوران راهنمایی با زبان برنامه نویسی ویژوال بیسیک آشنا شدم و بعد هم HTML و CSS  ودر سال 98 در دوره های آموزش سی شارپ و Asp.Net لایتک دوره دیدم.";




            return View();
        }
    }
}
