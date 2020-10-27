using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Data.Model
{
    public class GPSCoordinates
    {
        [Key]
        public int Id { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}
