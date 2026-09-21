using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork db=new UnitOfWork();

            dbo_Customers Customers = new dbo_Customers()
            {
                FullName = "Amir Mousavi",
                CustomerID = 1,
                Address = "isfahan",
                Moblie = "0900038338",
                Email = "amirmousavi@gmail.com",
                CustomerImage = "no Image",
            };
            db.CustomerRepository.InsertCustomer(Customers);
            db.CustomerRepository.Save();
            var list = db.CustomerRepository.GetAllCustomers();

            

            db.Dispose();
        }
    }
}
