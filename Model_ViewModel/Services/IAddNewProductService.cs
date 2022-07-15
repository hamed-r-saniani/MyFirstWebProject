using Model_ViewModel.Models.Dto;

namespace Model_ViewModel.Services
{
    public interface IAddNewProductService
    {
        ResultDto Execute(RequestAddNewProductDto request);
    }
}
