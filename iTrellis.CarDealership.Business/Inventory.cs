using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTrellis.CarDealership.Data;
using iTrellis.CarDealership.Data.Models;


namespace iTrellis.CarDealership.Business
{
    public class Inventory : IInventory
    {
        ICarDealershipContext _context;


        public Inventory(ICarDealershipContext context)
        {
            _context = context;
        }



        public async Task<List<CarModel>> GetAllCarsAsync()
        {
            return await _context.GetAllCarsAsync();
        }


        public async Task<List<CarModel>> SearchAsync(CarModel car)
        {
            //Normally I would use entity framework with IQueryable,
            //at the end call .ToList();

            //IQueryable<CarModel> inventory = context.Cars;
            //if (!string.IsNullOrEmpty(car.color))
            //{
            //    inventory = inventory.Where(x => x.color == car.color);
            //}
            //return cars.ToList();

            List<CarModel> inventory = await _context.GetAllCarsAsync();

            if (!string.IsNullOrEmpty(car.color))
            {
                inventory = inventory.Where(x => x.color == car.color).ToList();
            }
            if (car.searchHasSunroof != "")
            {
                inventory = inventory.Where(x => x.hasSunroof == Boolean.Parse(car.searchHasSunroof)).ToList();
            }
            if (car.searchIsFourWheelDrive != "")
            {
                inventory = inventory.Where(x => x.isFourWheelDrive == Boolean.Parse(car.searchIsFourWheelDrive)).ToList();
            }
            if (car.searchHasLowMiles != "")
            {
                inventory = inventory.Where(x => x.hasLowMiles == Boolean.Parse(car.searchHasLowMiles)).ToList();
            }
            if (car.searchHasPowerWindows != "")
            {
                inventory = inventory.Where(x => x.hasPowerWindows == Boolean.Parse(car.searchHasPowerWindows)).ToList();
            }
            if (car.searchHasNavigation != "")
            {
                inventory = inventory.Where(x => x.hasNavigation == Boolean.Parse(car.searchHasNavigation)).ToList();
            }
            if (car.searchHasHeatedSeats != "")
            {
                inventory = inventory.Where(x => x.hasHeatedSeats == Boolean.Parse(car.searchHasHeatedSeats)).ToList();
            }


            return inventory;

        }




    }
}
