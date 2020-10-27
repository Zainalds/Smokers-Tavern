using SmokersTavernStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Service
{
    public interface IArchiveRepository : IDisposable
    {
        List<Archive> GetAll();
        void Insert(Archive model);
        Archive GetById(Int32 id);
        void Delete(Archive model);
        IEnumerable<Archive> Find(Func<Archive, bool> predicate);
    }
}
