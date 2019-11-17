import { Component, OnInit  } from '@angular/core';
import { InventoryService } from '../../services/inventory.service';
import { Car } from '../../models/car';

@Component({
    selector: 'iTrellis-inventory',
    templateUrl: './inventory.component.html'
})

export class InventoryComponent implements OnInit {

    cars: any = [];

    color: string;
    hasSunroof: boolean = null;
    isFourWheelDrive: boolean = null;
    hasLowMiles: boolean = null;
    hasPowerWindows: boolean = null;
    hasNavigation: boolean = null;
    hasHeatedSeats: boolean = null;



    constructor(private inventoryService: InventoryService) { }

    
    ngOnInit() {
    }



    search() {

        let car = new Car;
        car.color = this.color;

        console.log('this.hasSunroof', this.hasSunroof);
        console.log('this.hasSunroof', this.hasSunroof === null);


        car.searchHasSunroof = this.hasSunroof === null ? '' : this.hasSunroof.toString();
        car.searchIsFourWheelDrive = this.isFourWheelDrive === null ? '' : this.isFourWheelDrive.toString();
        car.searchHasLowMiles = this.hasLowMiles === null ? '' : this.hasLowMiles.toString();
        car.searchHasPowerWindows = this.hasPowerWindows === null ? '' : this.hasPowerWindows.toString();
        car.searchHasNavigation = this.hasNavigation === null ? '' : this.hasNavigation.toString();
        car.searchHasHeatedSeats = this.hasHeatedSeats === null ? '' : this.hasHeatedSeats.toString();


        
        this.loadInventory(car);
    }


    loadInventory(car: Car) {
        return this.inventoryService.Search(car).subscribe((cars: {}) => {
            this.cars = cars;
        })
    }



}
