using SmokersTavernStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Business.Interfaces
{
    public interface IOrderBusiness
    {
        void Insert(OrderViewModel model);
        void InsertGPS(GPSCoordinatesViewModel model);
        IEnumerable<OrderViewModel> GetAllOrder();
        IEnumerable<OrderViewModel> GetPendingOrders();
        IEnumerable<OrderViewModel> GetDispatchedOrders();
        IEnumerable<OrderViewModel> GetDeliveredOrders();
        IEnumerable<OrderViewModel> GetReturnedOrders();
        OrderViewModel GetById(Int32 id);
        void Update(OrderViewModel model);
        OrderViewModel deleteMethod(int id);
        void PostDeleteMethod(int id);
        IEnumerable<OrderViewModel> GetAllOrderCustomer();
        IEnumerable<OrderViewModel> GetAllPendingOrders();
        IEnumerable<OrderViewModel> GetAllDispatchedOrders();
        IEnumerable<OrderViewModel> GetAllDeliveredOrders();
        IEnumerable<OrderViewModel> GetAllReturnedOrders();
    }
}
