using Microsoft.EntityFrameworkCore;
using Model_ViewModel.Models;
using Model_ViewModel.Models.Dto;
using System.Linq;

namespace Model_ViewModel.Services
{
    public class GetProductForAdminService : IGetProductForAdminService
    {
        private readonly IDatabaseContext _context;
        public GetProductForAdminService(IDatabaseContext context)
        {
            _context = context;
        }

        public ResultDto<ProductForAdminDto> Execute()
        {
            var products = _context.Product
                .Include(p => p.Category)
                .Select(p => new ProductsFormAdminList_Dto
                {
                    Id = p.ProductID,
                    Category = p.Category.CategoryName,
                    Description = p.ProductDesc,
                    Name = p.ProductName,
                    Price = (int)p.ProductPrice
                }).ToList();

            return new ResultDto<ProductForAdminDto>()
            {
                Data = new ProductForAdminDto()
                {
                    Products = products
                },
                IsSuccess = true,
                Message = "",
            };
        }
    }
}
