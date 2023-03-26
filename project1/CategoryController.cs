using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class CategoryController 
    {
        
       // public List<Category> productList = new List<Category>();
        private List<Category> productList;
        public CategoryController()
        {
           
            productList = new List<Category>();
        }

        public (string record,bool result)  AddProduct(Category addproduct)
        {



            //foreach (var data in productList)
            //{
            //    //if(data.Categoryid != null && !productList.Any(x=>x.Categoryid == data.categoryname))
            //    var maxid = productList.Any() ? productList.Max(x => x.Categoryid) : 0;
            //    data.Categoryid = maxid + 1;

            //}
            int Max = productList.Any() ? productList.Max(e => e.Categoryid) : 0; addproduct.Categoryid = Max + 1;
            productList.Add(addproduct);
            return ("Data Inserted Successfully :)",true);
        }
        public void DisplayProducts()
        {
            Console.WriteLine("Products:");
            foreach (var prod in productList)
            {
                Console.WriteLine($"Category ID : {prod.Categoryid} , Category Name : {prod.CategoryName}");

            }
        }
        public void DeleteProducts(string name)
        {
            var pname = productList.Single(each => each.CategoryName == name);
            productList.Remove(pname);
            Console.WriteLine("Delete Category Successfully :) ");
        }
        public void UpdateProduct(string Originalvalue, string Uservalue)
        {
            foreach (var val in productList)
            {
                if (val.CategoryName == Originalvalue)
                {
                    val.CategoryName = Uservalue;
                    Console.WriteLine("Update Category Successfully :) ");

                }
            }
        }

    }
}
