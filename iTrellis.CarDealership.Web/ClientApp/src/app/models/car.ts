
export class Car {

    constructor(public id?: string,
        public make?: string,
        public year?: number,
        public color?: string,
        public price?: number,
        public hasSunroof?: boolean,
        public isFourWheelDrive?: boolean,
        public hasLowMiles?: boolean,
        public hasPowerWindows?: boolean,
        public hasNavigation?: boolean,
        public hasHeatedSeats?: boolean,

        public searchHasSunroof?: string,
        public searchIsFourWheelDrive?: string,
        public searchHasLowMiles?: string,
        public searchHasPowerWindows?: string,
        public searchHasNavigation?: string,
        public searchHasHeatedSeats?: string,

    ) { }
}


