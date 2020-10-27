using SmokersTavernStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Service
{
    public interface ICustomerReturnsRepository : IDisposable
    {
        CustomerReturns GetById(Int32 id);
        List<CustomerReturns> GetAll();
        void Insert(CustomerReturns model);
        void Update(CustomerReturns model);
        void Delete(CustomerReturns model);
        IEnumerable<CustomerReturns> Find(Func<CustomerReturns, bool> predicate);
    }
}
