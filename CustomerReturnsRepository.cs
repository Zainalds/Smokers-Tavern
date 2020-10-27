using SmokersTavernStore.Data;
using SmokersTavernStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Service
{
    public class CustomerReturnsRepository : ICustomerReturnsRepository
    {
        private ApplicationDbContext _datacontext = null;
        private readonly IRepositoryService<CustomerReturns> _returnsRepository;

        public CustomerReturnsRepository()
        {
            _datacontext = new ApplicationDbContext();
            _returnsRepository = new RepositoryService<CustomerReturns>(_datacontext);

        }

        public void Dispose()
        {
            _datacontext.Dispose();
            _datacontext = null;
        }

        public CustomerReturns GetById(int id)
        {
            return _returnsRepository.GetById(id);
        }

        public List<CustomerReturns> GetAll()
        {
            return _returnsRepository.GetAll().ToList();
        }

        public void Insert(CustomerReturns model)
        {
            _returnsRepository.Insert(model);
        }

        public void Update(CustomerReturns model)
        {
            _returnsRepository.Update(model);
        }

        public void Delete(CustomerReturns model)
        {
            _returnsRepository.Delete(model);
        }
        public IEnumerable<CustomerReturns> Find(Func<CustomerReturns, bool> predicate)
        {
            return _returnsRepository.Find(predicate).ToList();
        }
    }
}
