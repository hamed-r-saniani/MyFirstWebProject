using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_ViewModel.Models.ViewModel
{
    public class SampleIndexViewModel
    {
        public SampleIndexViewModel(List<Product> Products, List<Category> Categories)
        {
            this.Products = Products;
            this.Categories = Categories;
        }
        public List<Product> Products;
        public List<Category> Categories;
    }
}
