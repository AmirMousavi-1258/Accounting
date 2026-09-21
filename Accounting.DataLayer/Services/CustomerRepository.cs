using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.ViewModels.Costumers;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Acounting_DBEntities db;

        public CustomerRepository(Acounting_DBEntities context)
        {
            db = context;
        }

        public List<dbo_Customers> GetAllCustomers()
        {
            return db.dbo_Customers.ToList();
        }

        public dbo_Customers GetCustomerById(int customerId)
        {
            return db.dbo_Customers.Find(customerId);
        }

        public bool InsertCustomer(dbo_Customers customer)
        {
            try
            {
                db.dbo_Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(dbo_Customers customer)
        {
            var local = db.Set<dbo_Customers>().Local.FirstOrDefault(f => f.CustomerID == customer.CustomerID);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(customer).State = EntityState.Modified ;
            return true;
            //try
            //{
            //    db.Entry(customer).State = EntityState.Modified;
            //    return true;
            //}
            //catch
            //{
            //    return false;
            //}
        }

        public bool DeleteCustomer(dbo_Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        

        public IEnumerable<dbo_Customers> getCustomerByFilter(string filter)
        {
            return db.dbo_Customers.Where(c=>c.FullName.Contains(filter)||c.Address.Contains(filter)||c.Moblie.Contains(filter)).ToList();
        }

        public List<ListCustomerViewModel> GetNames(string filter = "")
        {
            
            if(filter == "")
            {
                return db.dbo_Customers.Select(c => new ListCustomerViewModel()
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName,
                }).ToList();
            }
            return db.dbo_Customers.Where(c => c.FullName.Contains(filter)).Select(c=>new ListCustomerViewModel()
            {
                CustomerID = c.CustomerID,
                FullName = c.FullName,
            }).ToList();
        }

        public int GetCustomerIdByName(string name)
        {
            return db.dbo_Customers.First(c => c.FullName == name).CustomerID;
        }
        public string GetCustomerNameByID(int id)
        {
            return db.dbo_Customers.Find(id).FullName;
        }
    }
}
