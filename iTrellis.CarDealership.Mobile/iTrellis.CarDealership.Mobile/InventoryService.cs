using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using iTrellis.CarDealership.Data.Models;

using iTrellis.CarDealership.Data;

namespace iTrellis.CarDealership.Mobile
{
    class InventoryService
    {

        HttpClient _client;

        public InventoryService()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

    

        public async Task<List<CarModel>> SearchAsync(CarModel car)
        {
            List<CarModel> cars = null;

            try
            {
                string uri = "https://192.168.1.2:45456/api/inventory/search";

                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(car));
                HttpResponseMessage response = await _client.PostAsync(uri, httpContent);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    cars = JsonConvert.DeserializeObject<List<CarModel>>(content);

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\tERROR {0}", ex.Message);
            }

            return cars;
        }
    }


}

