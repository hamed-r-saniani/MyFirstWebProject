using Model_ViewModel.Models.Dto;

namespace Model_ViewModel.Services
{
    public interface IGetProductDetailForAdminService
    {
        ResultDto<ProductDetailForAdmindto> Execute(long Id);
    }
}
