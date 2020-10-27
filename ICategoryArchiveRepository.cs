using SmokersTavernStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Service
{
    public interface ICategoryArchiveRepository : IDisposable
    {
        List<CategoryArchive> GetAll();
        void Insert(CategoryArchive model);
    }
}
