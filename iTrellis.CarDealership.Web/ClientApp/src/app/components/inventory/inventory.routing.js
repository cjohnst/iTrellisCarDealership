"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var router_1 = require("@angular/router");
var inventory_component_1 = require("./inventory.component");
var ROUTES = [
    { path: '', component: inventory_component_1.InventoryComponent, pathMatch: 'full' },
];
exports.InventoryRouting = router_1.RouterModule.forChild(ROUTES);
//# sourceMappingURL=inventory.routing.js.map