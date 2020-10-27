using SmokersTavernStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Business.Interfaces
{
    public interface ICustomerReturnsBusiness
    {
        IEnumerable<CustomerReturnsViewModel> GetAll();
        void Insert(CustomerReturnsViewModel model);
        CustomerReturnsViewModel GetById(int Id);
        void Update(CustomerReturnsViewModel model);
    }
}
