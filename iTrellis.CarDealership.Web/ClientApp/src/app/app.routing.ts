import { Routes, RouterModule } from "@angular/router";
import { HomeComponent } from './components/home/home.component';


const APP_ROUTES: Routes = [
    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'inventory3', loadChildren: './components/inventory/inventory.module#InventoryModule' },
    { path: `inventory`, loadChildren: () => import('./components/inventory/inventory.module').then(m => m.InventoryModule) }
];

export const AppRouting = RouterModule.forRoot(APP_ROUTES);
