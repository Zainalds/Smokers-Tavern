using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokersTavernStore.Model
{
    public class GPSCoordinatesViewModel
    {
        [Key]
        public int Id { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }
}
