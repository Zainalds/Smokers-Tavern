using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Data.Model
{
    public class CustomerProfile
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Website { get; set; }
        public string PublicInfo { get; set; }
        public string Email { get; set; }
        public string DeliveryAddress { get; set; }
    }
}
