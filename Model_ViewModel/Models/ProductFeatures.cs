using Model_ViewModel.Models.Dto;

namespace Model_ViewModel.Models
{
    public class ProductFeatures : BaseEntity
    {
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public string DisplayName { get; set; }
        public string Value { get; set; }
    }
}
