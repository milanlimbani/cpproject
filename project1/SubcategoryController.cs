using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class SubcategoryController
    {
        //  public List<SubCategory> ProductSubcategory = new List<SubCategory>();

        private List<SubCategory> ProductSubcategory;
        public SubcategoryController()
        {

            ProductSubcategory = new List<SubCategory>();
        }

        public void AddProduct(SubCategory addproduct)
        {


            ProductSubcategory.Add(addproduct);
        }
        public void DisplayProduct()
        {
            foreach (var prod in ProductSubcategory)
            {
                Console.WriteLine($"SubCategory ID : {prod.SubCategoryId} , Category ID : {prod.CategoryId} , Subcategory Name : {prod.SubCategoryName}");
            }
        }
        public void DeleteProducts(string name)
        {
            var pname = ProductSubcategory.Single(each => each.SubCategoryName == name);
            ProductSubcategory.Remove(pname);
            Console.WriteLine("Delete SubCategory Successfully :) ");
        }
        public void UpdateProduct(string Originalvalue, string Uservalue)
        {
            foreach (var val in ProductSubcategory)
            {
                if (val.SubCategoryName == Originalvalue)
                {
                    val.SubCategoryName = Uservalue;
                    Console.WriteLine("Update Subcategory Successfully :) ");

                }
            }
        }
    }
}
