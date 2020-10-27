using SmokersTavernStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Business.Interfaces
{
    public interface IContactBusiness
    {
        IEnumerable<ContactViewModel> GetAll();
    }
}
