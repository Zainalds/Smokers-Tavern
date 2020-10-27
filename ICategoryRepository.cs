using SmokersTavernStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Service
{
    public interface ICategoryRepository : IDisposable
    {
        Category GetById(Int32 id);
        List<Category> GetAll();
        void Insert(Category model);
        void Update(Category model);
        void Delete(Category model);
        IEnumerable<Category> Find(Func<Category, bool> predicate);
    }
}
