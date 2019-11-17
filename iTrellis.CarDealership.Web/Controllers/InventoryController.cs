using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using iTrellis.CarDealership.Data.Models;
using iTrellis.CarDealership.Business;

namespace iTrellis.CarDealership.Web.Controllers
{
    [ApiController]
    [Route("api/inventory")]
    public class InventoryController : ControllerBase
    {


        [HttpGet]
        [Route("")]
        public List<CarModel> GetAllCars()
        {
            var inventory = new Inventory();
            return inventory.GetAllCars();
        }


        [HttpPost]
        [Route("Search")]
        public List<CarModel> Search([FromBody] CarModel car)
        {
            var inventory = new Inventory();
            return inventory.Search(car);
        }

    }
}
