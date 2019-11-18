using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace iTrellis.CarDealership.Data.Models
{
    public class CarModel
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("make")]
        public string make { get; set; }

        [JsonProperty("year")]
        public int year { get; set; }

        [JsonProperty("color")] 
        public string color { get; set; }

        [JsonProperty("price")] 
        public decimal price { get; set; }

        [JsonProperty("hasSunroof")] 
        public bool hasSunroof { get; set; }

        [JsonProperty("isFourWheelDrive")] 
        public bool isFourWheelDrive { get; set; }

        [JsonProperty("hasLowMiles")] 
        public bool hasLowMiles { get; set; }

        [JsonProperty("hasPowerWindows")] 
        public bool hasPowerWindows { get; set; }

        [JsonProperty("hasNavigation")] 
        public bool hasNavigation { get; set; }

        [JsonProperty("hasHeatedSeats")] 
        public bool hasHeatedSeats { get; set; }


        [JsonProperty("searchHasSunroof")]
        public string searchHasSunroof { get; set; }

        [JsonProperty("searchIsFourWheelDrive")]
        public string searchIsFourWheelDrive { get; set; }

        [JsonProperty("searchHasLowMiles")]
        public string searchHasLowMiles { get; set; }

        [JsonProperty("searchHasPowerWindows")]
        public string searchHasPowerWindows { get; set; }

        [JsonProperty("searchHasNavigation")]
        public string searchHasNavigation { get; set; }

        [JsonProperty("searchHasHeatedSeats")]
        public string searchHasHeatedSeats { get; set; }


    }
}
