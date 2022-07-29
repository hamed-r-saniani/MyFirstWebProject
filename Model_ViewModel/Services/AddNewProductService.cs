using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Model_ViewModel.Models;
using Model_ViewModel.Models.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Model_ViewModel.Services
{
    public class AddNewProductService : IAddNewProductService
    {
        private readonly IDatabaseContext _context;
        private readonly IHostingEnvironment _environment;

        public AddNewProductService(IDatabaseContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;
        }


        public ResultDto Execute(RequestAddNewProductDto request)
        {

            try
            {

                var category = _context.Category.Find((int)request.CategoryId);
                var lastProductId = _context.Product.Last().ProductID;

                Product product = new Product()
                {
                    ProductID = ++lastProductId,
                    CreateDate = DateTime.Now,
                    ProductDesc = request.Description,
                    ProductName = request.Name,
                    ProductPrice = request.Price,
                    ProductCategoryID = category.CategoryID,
                    CategoryID = category.CategoryID,
                    Category = category,
                    PersonID = 1,
                    Person = new Person() { PersonID = 1},
                    ProductImage = UploadFile(request.Images.FirstOrDefault())?.FileNameAddress ?? ""
                };
                

                List<ProductImages> productImages = new List<ProductImages>();
                foreach (var item in request.Images)
                {
                    var uploadedResult = UploadFile(item);
                    productImages.Add(new ProductImages
                    {
                        Product = product,
                        Src = uploadedResult.FileNameAddress,
                    });
                }            


                List<ProductFeatures> productFeatures = new List<ProductFeatures>();
                foreach (var item in request.Features)
                {
                    productFeatures.Add(new ProductFeatures
                    {
                        DisplayName = item.DisplayName,
                        Value = item.Value,
                        Product = product,
                    });
                }

                
                _context.Product.Add(product);
                _context.ProductImages.AddRange(productImages);
                _context.ProductFeatures.AddRange(productFeatures);

                _context.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "محصول با موفقیت به محصولات فروشگاه اضافه شد",
                };
            }
            catch (Exception ex)
            {

                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "خطا رخ داد ",
                };
            }

        }



        private UploadDto UploadFile(IFormFile file)
        {
            if (file != null)
            {
                string folder = $@"images\ProductImages\";
                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, folder);
                if (!Directory.Exists(uploadsRootFolder))
                {
                    Directory.CreateDirectory(uploadsRootFolder);
                }


                if (file == null || file.Length == 0)
                {
                    return new UploadDto()
                    {
                        Status = false,
                        FileNameAddress = "",
                    };
                }

                string fileName = DateTime.Now.Ticks.ToString() + file.FileName;
                var filePath = Path.Combine(uploadsRootFolder, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                return new UploadDto()
                {
                    FileNameAddress = folder + fileName,
                    Status = true,
                };
            }
            return null;
        }
    }
}
