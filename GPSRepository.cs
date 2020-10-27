using SmokersTavernStore.Data;
using SmokersTavernStore.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Service
{
    public class GPSRepository : IGPSRepository
    {
        private ApplicationDbContext _datacontext = null;
        private readonly IRepositoryService<GPSCoordinates> _orderRepository;

        public GPSRepository()
        {
            _datacontext = new ApplicationDbContext();
            _orderRepository = new RepositoryService<GPSCoordinates>(_datacontext);
        }


        public void Insert(GPSCoordinates model)
        {
            _orderRepository.Insert(model);
        }

       
        public void Dispose()
        {
            _datacontext.Dispose();
            _datacontext = null;
        }
    }
}
