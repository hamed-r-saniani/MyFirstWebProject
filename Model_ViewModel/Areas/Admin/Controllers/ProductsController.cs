using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model_ViewModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SENTAK_STORE.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly IDatabaseContext _context;

        public ProductsController(IDatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Product.ToList());
        }

        public IActionResult Detail(int id)
        {
            return View(_context.Product.Where(x => x.ProductID == id).FirstOrDefault());
        }

        [HttpGet]
        public IActionResult AddNewProduct()
        {
            ViewBag.Categories = new SelectList(_productFacad.GetAllCategoriesService.Execute().Data, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddNewProduct(RequestAddNewProductDto request, List<AddNewProduct_Features> Features)
        {
            List<IFormFile> images = new List<IFormFile>();
            for (int i = 0; i < Request.Form.Files.Count; i++)
            {
                var file = Request.Form.Files[i];
                images.Add(file);
            }
            request.Images = images;
            request.Features = Features;
            return Json(_productFacad.AddNewProductService.Execute(request));
        }
    }
}
