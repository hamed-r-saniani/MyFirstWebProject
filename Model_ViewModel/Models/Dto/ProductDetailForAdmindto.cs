using System.Collections.Generic;

namespace Model_ViewModel.Models.Dto
{
    public class ProductDetailForAdmindto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public List<ProductDetailFeatureDto> Features { get; set; }
        public List<ProductDetailImagesDto> Images { get; set; }
    }
}
