using Microsoft.EntityFrameworkCore;
using Model_ViewModel.Models;
using Model_ViewModel.Models.Dto;
using System.Linq;

namespace Model_ViewModel.Services
{
    public class GetProductDetailForAdminService : IGetProductDetailForAdminService
    {
        private readonly IDatabaseContext _context;

        public GetProductDetailForAdminService(IDatabaseContext context)
        {
            _context = context;
        }

        public ResultDto<ProductDetailForAdmindto> Execute(long Id)
        {
            var product = _context.Product
                .Include(p => p.Category)
                .Include(p => p.ProductFeatures)
                .Include(p => p.ProductImages)
                .Where(p => p.ProductID == Id)
                .FirstOrDefault();
            return new ResultDto<ProductDetailForAdmindto>()
            {
                Data = new ProductDetailForAdmindto()
                {
                    Category = GetCategory(product.Category),
                    Description = product.ProductDesc,
                    Id = product.ProductID,
                    Name = product.ProductName,
                    Price = (int)product.ProductPrice,
                    Features = product.ProductFeatures.ToList().Select(p => new ProductDetailFeatureDto
                    {
                        Id = p.Id,
                        DisplayName = p.DisplayName,
                        Value = p.Value
                    }).ToList(),
                    Images = product.ProductImages.ToList().Select(p => new ProductDetailImagesDto
                    {
                        Id = p.Id,
                        Src = p.Src,
                    }).ToList(),
                },
                IsSuccess = true,
                Message = "",
            };
        }

        private string GetCategory(Category category)
        {
            return  category.CategoryName;
        }
    }
}
