using SmokersTavernStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Service
{
    public interface IBranchRepository : IDisposable
    {
        Branch GetById(Int32 id);
        List<Branch> GetAll();
        void Insert(Branch model);
        void Update(Branch model);
        void Delete(Branch model);
        IEnumerable<Branch> Find(Func<Branch, bool> predicate);
    }
}
