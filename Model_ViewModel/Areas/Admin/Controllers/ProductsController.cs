using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model_ViewModel.Models;
using Model_ViewModel.Models.Dto;
using Model_ViewModel.Services;
using System.Collections.Generic;
using System.Linq;

namespace SENTAK_STORE.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly IDatabaseContext _context;
        private readonly IAddNewProductService _addNewProductService;
        private readonly IGetProductForAdminService _getProductForAdminService;
        private readonly IGetProductDetailForAdminService _getProductDetailForAdminService;

        public ProductsController(IDatabaseContext context, IAddNewProductService addNewProductService, IGetProductForAdminService getProductForAdminService, IGetProductDetailForAdminService getProductDetailForAdminService)
        {
            _context = context;
            _addNewProductService = addNewProductService;
            _getProductForAdminService = getProductForAdminService;
            _getProductDetailForAdminService = getProductDetailForAdminService;
        }

        public IActionResult Index()
        {
            return View(_getProductForAdminService.Execute().Data);
        }

        public IActionResult Detail(int Id)
        {
            return View(_getProductDetailForAdminService.Execute(Id).Data);
        }

        [HttpGet]
        public IActionResult AddNewProduct()
        {
            ViewBag.Categories = new SelectList(_context.Category.ToList(), "CategoryID", "CategoryName");
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
            return Json(_addNewProductService.Execute(request));
        }
    }
}
