using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using iTrellis.CarDealership.Data.Models;


namespace iTrellis.CarDealership.Mobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        InventoryService _inventoryService;

        public MainPage()
        {
            InitializeComponent();
            _inventoryService = new InventoryService();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            CarModel car = new CarModel();
            car.color = color.SelectedItem == null ? "" : color.SelectedItem.ToString();

            //in Angular I have a tristate checkbox where you could search for cars
            //that has a Sunroof, does not, or both.
            //because of the switch, I can only search for has Sunroof or both true/false
            car.searchHasSunroof = hasSunroof.IsToggled ? "" : "true";
            car.searchIsFourWheelDrive = isFourWheelDrive.IsToggled ? "" : "true";
            car.searchHasLowMiles = hasLowMiles.IsToggled ? "" : "true";
            car.searchHasPowerWindows = hasPowerWindows.IsToggled ? "" : "true";
            car.searchHasNavigation = hasNavigation.IsToggled ? "" : "true";
            car.searchHasHeatedSeats = hasHeatedSeats.IsToggled ? "" : "true";

            List<CarModel> cars = await _inventoryService.SearchAsync(car);
            inventory.ItemsSource = cars;
        }

      

    }
}
