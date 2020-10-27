using SmokersTavernStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Business.Interfaces
{
    public interface IStockTransactionBusiness
    {
        void Insert(StockTransactionsViewModel model);
        IEnumerable<StockTransactionsViewModel> GetAllStockTransactions();
        void DecreaseProductQuantity(StockTransactionsViewModel model);
        void IncreaseQuantity(StockTransactionsViewModel model);
    }
}
