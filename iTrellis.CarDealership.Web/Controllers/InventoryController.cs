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
        IInventory _inventory;

        public InventoryController(IInventory inventory)
        {
            _inventory = inventory;
        }

        [HttpGet]
        [Route("")]
        public async Task<List<CarModel>> GetAllCars()
        {
            return await _inventory.GetAllCarsAsync();
        }


        [HttpPost]
        [Route("Search")]
        public async Task<List<CarModel>> Search([FromBody] CarModel car)
        {
            return await _inventory.SearchAsync(car);
        }

    }
}
