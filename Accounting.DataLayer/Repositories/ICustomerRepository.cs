using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels.Costumers;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        
        List<dbo_Customers> GetAllCustomers();
        dbo_Customers GetCustomerById(int customerId);
        IEnumerable<dbo_Customers> getCustomerByFilter(string filter);
        List<ListCustomerViewModel> GetNames(string filter = "");
        bool InsertCustomer(dbo_Customers customer);
        bool UpdateCustomer(dbo_Customers customer);
        bool DeleteCustomer(dbo_Customers customer);
        bool DeleteCustomer(int customerId);
      
    }
}
