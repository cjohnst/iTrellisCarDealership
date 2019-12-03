using System.Collections.Generic;
using System.Threading.Tasks;
using iTrellis.CarDealership.Data.Models;

namespace iTrellis.CarDealership.Business
{
    public interface IInventory
    {
        Task<List<CarModel>> GetAllCarsAsync();
        Task<List<CarModel>> SearchAsync(CarModel car);
    }
}