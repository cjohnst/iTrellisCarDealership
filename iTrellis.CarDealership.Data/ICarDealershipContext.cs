using System.Collections.Generic;
using System.Threading.Tasks;
using iTrellis.CarDealership.Data.Models;

namespace iTrellis.CarDealership.Data
{
    public interface ICarDealershipContext
    {
        Task<List<CarModel>> GetAllCarsAsync();

    }
}