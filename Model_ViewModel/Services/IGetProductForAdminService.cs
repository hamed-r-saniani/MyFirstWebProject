using Model_ViewModel.Models.Dto;

namespace Model_ViewModel.Services
{
    public interface IGetProductForAdminService
    {
        ResultDto<ProductForAdminDto> Execute(int Page = 1, int PageSize = 20);
    }
}
