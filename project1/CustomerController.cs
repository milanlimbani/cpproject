using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{

    class CustomerController
    {
        private List<Customer> CustomerData = new List<Customer>();
        static int price = 0;
        public CustomerController()
        {
            CustomerData = new List<Customer>();
        }
        public void MakeOrder(Customer cust,int p)
        {
            price = p;
            CustomerData.Add(cust);
        }

        public void ViewBill()
        {
            foreach (var vb in CustomerData)
            {
                Console.WriteLine($"Order ID : {vb.id} , Customer name : {vb.Name} , Product Name : {vb.pname} , Product Price : {price} ,Product Qty : {vb.qty},Total Price : {price*vb.qty},Customer Phono : {vb.Phoneno} , Customer Address : {vb.Address} ");
            }
        }
    }
}
