using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTrellis.CarDealership.Data.Models
{
    public class CarModel
    {
        public string id { get; set; }
        public string make { get; set; }
        public int year { get; set; }
        public string color { get; set; }
        public decimal price { get; set; }
        public bool hasSunroof { get; set; }
        public bool isFourWheelDrive { get; set; }
        public bool hasLowMiles { get; set; }
        public bool hasPowerWindows { get; set; }
        public bool hasNavigation { get; set; }
        public bool hasHeatedSeats { get; set; }

        public string searchHasSunroof { get; set; }
        public string searchIsFourWheelDrive { get; set; }
        public string searchHasLowMiles { get; set; }
        public string searchHasPowerWindows { get; set; }
        public string searchHasNavigation { get; set; }
        public string searchHasHeatedSeats { get; set; }


    }
}
