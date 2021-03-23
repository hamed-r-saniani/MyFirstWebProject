using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_ViewModel.Models.ViewModel
{
    public class SampleDetailsViewModel
    {
        public SampleDetailsViewModel(Product Product, List<Category> Category)
        {
            this.Product = Product;
            this.Category = Category;
        }
        public Product Product { get; set; }
        public List<Category> Category { get; set; }
    }
}
