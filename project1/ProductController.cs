using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class ProductController
    {
        // public List<Products> ProductData = new List<Products>();
        //  public List<Produc> ProductData;
        private List<Produc> ProductData = new List<Produc>();
        public ProductController()
        {
            ProductData = new List<Produc>();
        }
        public void AddProduct(Produc addproduct)
        {

            ProductData.Add(addproduct);
        }
        public List<Produc> GetAllProducts()
        {
            return ProductData;
        }
        //public void AddProduct(int Pid,int SubCcatId,string Productname,string CompanyName,int Price)
        //{
        //    Produc newProduct = new Produc();
        //    newProduct.Productid = Pid;
        //    newProduct.SubCategoryId = SubCcatId;
        //    newProduct.ProductName = Productname;
        //    newProduct.CompanyName = CompanyName;
        //    newProduct.Price = Price;

        //    ProductData.Add(newProduct);
        //}
        public void DisplayProduct()
        {
            foreach (var prod in ProductData)
            {
                Console.WriteLine($"Product ID : {prod.Productid} , Subcategory ID : {prod.SubCategoryId} , Product Name : {prod.ProductName} , Product CompanyName : {prod.CompanyName},Product Quantity : {prod.Qty} , Price : {prod.Price} ");
            }
        }
        //public list<produc> getQty()
        //{
        //    return ;
        //}
        public void DeleteProducts(string name)
        {
            //var pname = ProductData.Single(each => each.ProductName == name);
            //ProductData.Remove(pname);
            var remove = ProductData.Where(a => a.ProductName == name);
            ProductData = ProductData.Except(remove).ToList();
            foreach (var p in ProductData)
            {
                Console.WriteLine($" Product Id : {p.Productid} \t Product Name : {p.ProductName}");
            }
        }
        public void UpdateProduct(string Originalvalue, string Uservalue, int qty, int price)
        {
            ProductData = ProductData.Where(w => w.ProductName == Originalvalue).Select(w => { w.ProductName = Uservalue; w.Qty = qty; w.Price = price; return w; }).ToList();
            foreach (var p in ProductData)
            {
                Console.WriteLine($"Sub-Category Id : {p.SubCategoryId} \t Product Id : {p.Productid} \t Product Name : {p.ProductName} \t Product Quantity" + $" : {p.Qty} \t Product Price : {p.Price}");
            }
        }
    }
}
