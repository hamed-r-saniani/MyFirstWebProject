using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model_ViewModel.Models
{
    public class Category
    {
        [Key]
        public Guid Guid { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Product { get; set; }

        public List<Category> GetCategory()
        {
            var CategoryList = new List<Category>() {

                new Category{

                    CategoryID = 1, CategoryName = "لپ تاپ",

                },
                new Category{

                    CategoryID = 2, CategoryName = "موبایل",

                },
                new Category{

                    CategoryID = 3, CategoryName = "تبلت",

                },

            };
            return CategoryList;
        }
    }
}
