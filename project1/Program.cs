using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
  
    class Program
    {

      static  ProductController productRepository = new ProductController();
        static void Main(string[] args)
        {


            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("======== Welcome ==========");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AdminMenu();
                        break;
                    case 2:
                        UserMenu();
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void AdminMenu()
        {
            var catList = new CategoryController();
            var category = new Category();
            var subcategoryList = new SubcategoryController();
            var ProductList = new ProductController();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Admin Menu");
                Console.WriteLine("1. Add Category");
                Console.WriteLine("2. Display Category");
                Console.WriteLine("3. Update Category");
                Console.WriteLine("4. Delete Category");
                Console.WriteLine("5. Add Subcategory");
                Console.WriteLine("6. Display Subcategory");
                Console.WriteLine("7. Update Subcategory");
                Console.WriteLine("8. Delete Subcategory");
                Console.WriteLine("9. Add Products");
                Console.WriteLine("10. Display Products");
                Console.WriteLine("11. Update Products");
                Console.WriteLine("12. Delete Products");
                Console.WriteLine("13. Back");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //Console.Write("Enter Category Id: ");
                        //var Catid = int.Parse(Console.ReadLine());
                        //   Console.Write("Enter Category Id: ");
                        // int Catid =1;
                        Console.Write("Enter Category Name: ");
                        var CatName = Console.ReadLine();
                        var CatData = new Category
                        {

                            Categoryid = category.Categoryid,
                            CategoryName = CatName,

                        };

                        var d = catList.AddProduct(CatData);
                        Console.WriteLine($"{d.record}");
                        break;
                    case 2:
                        catList.DisplayProducts();
                        break;
                    case 3:
                        Console.Write("Enter Actual Category Name: ");
                        var CategoryNames = Console.ReadLine();
                        Console.Write("Enter Change Category Name: ");
                        var chcatname = Console.ReadLine();
                        catList.UpdateProduct(CategoryNames, chcatname);
                        break;
                    case 4:
                        Console.Write("Enter Category Name: ");
                        var CategoryName = Console.ReadLine();
                        catList.DeleteProducts(CategoryName);
                        break;
                    case 5:
                        Console.WriteLine("==== Your Category  =========");
                        catList.DisplayProducts();
                        Console.WriteLine("========= End ========== ");
                        Console.Write("Enter SubCategory ID: ");
                        var SubCatId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Category ID: ");
                        var CatId = int.Parse(Console.ReadLine());
                        Console.Write("Enter SubCategory Name: ");
                        var SubcatName = Console.ReadLine();
                        var SubcatData = new SubCategory
                        {

                            SubCategoryId = SubCatId,
                            CategoryId = CatId,
                            SubCategoryName = SubcatName

                        };
                        subcategoryList.AddProduct(SubcatData);
                        break;

                    case 6:
                        subcategoryList.DisplayProduct();
                        break;
                    case 7:
                        Console.Write("Enter Actual Subcategory Name: ");
                        var SubCategoryNames = Console.ReadLine();
                        Console.Write("Enter Change Subcategory Name: ");
                        var chsubcatname = Console.ReadLine();
                        subcategoryList.UpdateProduct(SubCategoryNames, chsubcatname);
                        break;
                    case 8:
                        Console.Write("Enter Subcategory Name: ");
                        var SubCategoryName = Console.ReadLine();
                        subcategoryList.DeleteProducts(SubCategoryName);
                        break;
                    case 9:
                        Console.WriteLine("==== Your Subcategory  =========");
                        subcategoryList.DisplayProduct();
                        Console.WriteLine("========= End ========== ");
                        Console.Write("Enter Product ID: ");
                        var Pid = int.Parse(Console.ReadLine());
                        Console.Write("Enter Subcategory ID: ");
                        var SubCcatId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Product Name: ");
                        var Productname = Console.ReadLine();
                        Console.Write("Enter Company Name: ");
                        var CompanyName = Console.ReadLine();
                        Console.Write("Enter Qty: ");
                        var qty =int.Parse(Console.ReadLine());
                        Console.Write("Enter Price: ");
                        var Price = int.Parse(Console.ReadLine());
                        //var ProductData = new Produc
                        //{

                        //    Productid = Pid,
                        //    SubCategoryId = SubCcatId,
                        //    ProductName = Productname,
                        //    CompanyName = CompanyName,
                        //    Price = Price

                        //};
                       Produc p = new Produc
                        {

                            Productid = Pid,
                            SubCategoryId = SubCcatId,
                            ProductName = Productname,
                            CompanyName = CompanyName,
                            Qty = qty,
                            Price = Price

                        };
                        productRepository.AddProduct(p);

                        //   p1.AddProduct(Pid, SubCcatId, Productname, CompanyName, Price);
            
                        break;
                    case 10:
                        productRepository.DisplayProduct();
                        break;
                    case 11:
                        Console.Write("Enter Actual Product Name: ");
                        var ProductNames = Console.ReadLine();
                        Console.Write("Enter Change Product Name: ");
                        var chProdname = Console.ReadLine();
                        Console.Write("Enter Updated Product Qty: ");
                        var pqty = int.Parse(Console.ReadLine());
                        Console.Write("Enter Price: ");
                        var pprice = int.Parse(Console.ReadLine());
                        productRepository.UpdateProduct(ProductNames, chProdname,pqty,pprice);
                        break;
                    case 12:
                        Console.Write("Enter Product Name: ");
                        var Productnames = Console.ReadLine();
                        productRepository.DeleteProducts(Productnames);
                        break;
                    case 13:

                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        static void UserMenu()
        {
           CustomerController customerDetails = new CustomerController();
            bool exitt = false;
            while (!exitt)
            {
                Console.WriteLine("User Menu");
                Console.WriteLine("1. View Product");
                Console.WriteLine("2. Make Order");
                Console.WriteLine("3. View Bill");
                Console.WriteLine("13. Back");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        //List<Produc> pro = productRepository.GetAllProducts();
                        //Console.WriteLine("All products:");
                        //foreach (Produc prod in pro)
                        //{
                        //    Console.WriteLine($"Product ID : {prod.Productid} , Subcategory ID : {prod.SubCategoryId} , Product Name : {prod.ProductName} , Product CompanyName : {prod.CompanyName} , Price : {prod.Price} ");

                        //}
                        productRepository.DisplayProduct();
                        break;
                    case 2:
                        Console.WriteLine("======= Display Product ========");
                        productRepository.DisplayProduct();
                        Console.WriteLine("======= End ========");

                        Console.Write("Enter Product Name: ");
                        var pname = Console.ReadLine();
                        Console.Write("Enter Product Qty: ");
                        var qty = int.Parse(Console.ReadLine());
                        Console.Write("Enter Customer Name: ");
                        var Name = Console.ReadLine();
                        Console.Write("Enter Phno: ");
                        var Phoneno = double.Parse(Console.ReadLine());
                        Console.Write("Enter Address: ");
                        var Address = (Console.ReadLine());
                        Customer custdetails = new Customer
                        {
                            pname = pname,
                            qty =qty,
                            Name=Name,
                            Phoneno=Phoneno,
                            Address=Address
                        };

                        List<Produc> abc = productRepository.GetAllProducts();

                        foreach (var prod in abc)
                        {
                           

                            if (prod.ProductName != pname)
                            {
                                Console.WriteLine("Product Not Available");

                            }
                            else if(prod.ProductName == pname) 
                            {
                                if(prod.Qty < qty)
                                {
                                    Console.WriteLine("Please Enter Valid Quantity");
                                }
                                else
                                {
                                    int p = prod.Price;
                                    customerDetails.MakeOrder(custdetails,p);
                                    prod.Qty -= qty;

                                }
                            }
                        }  
                        break;
                    case 3:
                        customerDetails.ViewBill();
                        break;
                    case 13:
                        exitt = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}


