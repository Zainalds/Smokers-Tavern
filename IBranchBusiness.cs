using SmokersTavernStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Business.Interfaces
{
    public interface IBranchBusiness
    {
        IEnumerable<BranchViewModel> GetAll();
        void Insert(BranchViewModel model);
        void Update(BranchViewModel model);
        //void Delete(int id);
        BranchViewModel GetByBranchId(int Id);
    }
}
