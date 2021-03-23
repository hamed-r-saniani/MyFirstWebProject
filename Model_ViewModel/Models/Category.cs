using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_ViewModel.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

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
