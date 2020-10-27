using SmokersTavernStore.Business.Interfaces;
using SmokersTavernStore.Data.Model;
using SmokersTavernStore.Model;
using SmokersTavernStore.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Business.Business_Logic
{
    public class CustomerReturnsBusiness : ICustomerReturnsBusiness
    {
        public void Insert(CustomerReturnsViewModel model)
        {
            using (var repo = new CustomerReturnsRepository())
            {
                repo.Insert(new CustomerReturns
                {
                    CustomerName = model.CustomerName,
                    Email = model.Email,
                    Item = model.Item,
                    Reason = model.Reason,
                    Status = model.Status,
                    PickUpDate = model.PickUpDate
                });
            }
        }

        public IEnumerable<CustomerReturnsViewModel> GetAll()
        {
            var customers = new List<CustomerReturnsViewModel>();

            using (var repository = new CustomerReturnsRepository())
            {
                customers = repository.GetAll().Select(model => new CustomerReturnsViewModel
                {
                    Id = model.Id,
                    CustomerName = model.CustomerName,
                    Email = model.Email,
                    Item = model.Item,
                    Reason = model.Reason,
                    Status = model.Status,
                    PickUpDate = model.PickUpDate

                }).ToList();
            }
            return customers;
        }


        public CustomerReturnsViewModel GetById(Int32 id)
        {
            using (var repository = new CustomerReturnsRepository())
            {
                return repository.Find(x => x.Id == id).Select(model => new CustomerReturnsViewModel
                {
                    Id = model.Id,
                    CustomerName = model.CustomerName,
                    Email = model.Email,
                    Item = model.Item,
                    Reason = model.Reason,
                    Status = model.Status,
                    PickUpDate = model.PickUpDate

                }).FirstOrDefault();
            }
        }

        public void Update(CustomerReturnsViewModel model)
        {

                using (var ord = new CustomerReturnsRepository())
                {
                    var o = new CustomerReturns();
                    o = ord.GetById(model.Id);
                    if (o != null)
                    {
                        o.Status = model.Status;
                        o.CustomerName = model.CustomerName;
                        o.Email = model.Email;
                        o.Item = model.Item;
                        o.Reason = model.Reason;
                        o.Status = model.Status;
                        o.PickUpDate = model.PickUpDate;

                        ord.Update(o);
                    }
                }
        }



    }
}
