﻿using SmokersTavernStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Service
{
    public interface IStockTransactionRepository : IDisposable
    {
        StockTransactions GetById(Int32 id);
        List<StockTransactions> GetAll();
        void Insert(StockTransactions model);
        void Update(StockTransactions model);
        void Delete(StockTransactions model);
        IEnumerable<StockTransactions> Find(Func<StockTransactions, bool> predicate);
    }
}
