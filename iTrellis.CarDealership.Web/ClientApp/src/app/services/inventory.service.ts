import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders  } from '@angular/common/http';
import { Car } from '../models/car';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class InventoryService {


    constructor(private httpClient: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

    // Http Headers
    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json'
        })
    }


    GetAllCars(): Observable<Car> {
        return this.httpClient.get<Car>(this.baseUrl + 'api/inventory/')
            .pipe(
                catchError(this.errorHandle)
            )
    }

    Search(car: Car): Observable<Car> {
        return this.httpClient.post<Car>(this.baseUrl + 'api/inventory/Search', JSON.stringify(car), this.httpOptions)
            .pipe(
                catchError(this.errorHandle)
            )
    }  


    // Error handling
    errorHandle(error) {
        let errorMessage = '';
        if (error.error instanceof ErrorEvent) {
            // Get client-side error
            errorMessage = error.error.message;
        } else {
            // Get server-side error
            errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
        }
        console.log(errorMessage);
        return throwError(errorMessage);
    }




}
