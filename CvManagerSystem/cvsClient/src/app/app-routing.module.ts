import {  NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { CreatecvComponent } from './createcv/createcv.component';
import { ListComponent } from './list/list.component';


const routes: Routes = [
   {path:'', component :ListComponent},
   {path:'create' , component: CreatecvComponent},
   {path:'edit/:id' , component: CreatecvComponent},
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
