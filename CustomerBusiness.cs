using SmokersTavernStore.Data;
using SmokersTavernStore.Data.Model;
using SmokersTavernStore.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Business.Business_Logic
{
    public class CustomerBusiness
    {
        public List<Customer> GetAllCustomers()
        {
            using (var customerRepo = new CustomerRepository(new ApplicationDbContext()))
            {
                return customerRepo.GetCustomers();
            }
        }

        public Customer GetCustomer(string email)
        {
            using (var customerRepo = new CustomerRepository(new ApplicationDbContext()))
            {
                return customerRepo.GetCustomerByEmail(email);
            }
        }
    }
}
