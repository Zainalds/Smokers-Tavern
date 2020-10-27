using SmokersTavernStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Service
{
    public interface IGPSRepository :IDisposable
    {
        void Insert(GPSCoordinates model);
    }
}
