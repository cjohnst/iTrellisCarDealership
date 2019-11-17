import { NgModule } from "@angular/core";
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { InventoryComponent } from "./inventory.component";
import { InventoryRouting } from "./inventory.routing";

import { PanelModule } from 'primeng/panel';
import { TableModule } from 'primeng/table';
import { TriStateCheckboxModule } from 'primeng/tristatecheckbox';

import { InventoryService } from '../../services/inventory.service';


@NgModule({
    declarations: [
        InventoryComponent
    ],
    imports: [
        InventoryRouting,
        CommonModule,
        FormsModule,
        PanelModule,
        TableModule,
        TriStateCheckboxModule
    ],
    providers: [
        InventoryService
    ]
})

export class InventoryModule { } 
