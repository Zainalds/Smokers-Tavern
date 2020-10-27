using SmokersTavernStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Service
{
    public interface ICustomerRepository : IDisposable
    {
        List<Customer> GetCustomers();
        Customer GetCustomerByEmail(string objEmail);
        void InsertCustomer(Customer model);
        void DeleteCustomer(Customer model);
        void UpdateCustomer(Customer model);
        void Save();
    }
}
