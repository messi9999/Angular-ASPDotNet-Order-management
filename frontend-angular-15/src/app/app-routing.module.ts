import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OrderBicycleComponent } from './components/order-bicycle/order-bicycle.component';

const routes: Routes = [
  {path: 'order', component: OrderBicycleComponent}
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
