using Model_ViewModel.Models.Dto;

namespace Model_ViewModel.Models
{
    public class ProductImages : BaseEntity
    {
        public virtual Product Product { get; set; }
        public long ProductId { get; set; }
        public string Src { get; set; }
    }

}
