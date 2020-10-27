using SmokersTavernStore.Data;
using SmokersTavernStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Service
{
    public class StockTransactionRepository : IStockTransactionRepository
    {
        private ApplicationDbContext _datacontext = null;
        private readonly IRepositoryService<StockTransactions> _StockTransRepository;

        public StockTransactionRepository()
        {
            _datacontext = new ApplicationDbContext();
            _StockTransRepository = new RepositoryService<StockTransactions>(_datacontext);

        }

        public void Dispose()
        {
            _datacontext.Dispose();
            _datacontext = null;
        }

        public StockTransactions GetById(int id)
        {
            return _StockTransRepository.GetById(id);
        }

        public List<StockTransactions> GetAll()
        {
            return _StockTransRepository.GetAll().ToList();
        }

        public void Insert(StockTransactions model)
        {
            _StockTransRepository.Insert(model);
        }

        public void Update(StockTransactions model)
        {
            _StockTransRepository.Update(model);
        }

        public void Delete(StockTransactions model)
        {
            _StockTransRepository.Delete(model);
        }

        public IEnumerable<StockTransactions> Find(Func<StockTransactions, bool> predicate)
        {
            return _StockTransRepository.Find(predicate).ToList();
        }
    }
}
