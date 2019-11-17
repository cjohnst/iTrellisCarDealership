import { Routes, RouterModule } from "@angular/router";

import { InventoryComponent } from "./inventory.component";

const ROUTES: Routes = [
    { path: '', component: InventoryComponent, pathMatch: 'full' },
];

export const InventoryRouting = RouterModule.forChild(ROUTES);
