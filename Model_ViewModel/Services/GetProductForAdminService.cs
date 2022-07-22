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

        public ResultDto<ProductForAdminDto> Execute(int Page = 1, int PageSize = 20)
        {
            int rowCount = 0;
            var products = _context.Product
                .Include(p => p.Category)
                .ToPaged(Page, PageSize, out rowCount)
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
                    Products = products,
                    CurrentPage = Page,
                    PageSize = PageSize,
                    RowCount = rowCount
                },
                IsSuccess = true,
                Message = ""
            };
        }
    }
}
