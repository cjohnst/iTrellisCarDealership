"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var router_1 = require("@angular/router");
var home_component_1 = require("./components/home/home.component");
var APP_ROUTES = [
    { path: '**', redirectTo: 'home' },
    { path: 'home', component: home_component_1.HomeComponent, pathMatch: 'full' },
    { path: 'inventory', loadChildren: './components/inventory/inventory.module#InventoryModule' },
];
exports.AppRouting = router_1.RouterModule.forRoot(APP_ROUTES);
//# sourceMappingURL=app.routing.js.map