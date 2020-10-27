using SmokersTavernStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Business.Interfaces
{
    public interface IStaffBusiness
    {
        void Insert(StaffViewModel model);
        List<StaffViewModel> GetAll();
        StaffViewModel GetStaffById(int id);
        void Update(StaffViewModel model);
        StaffViewModel GETeditMethod(int? id);
    }
}
