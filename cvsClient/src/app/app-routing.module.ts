import {  NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { CreatecvComponent } from './createcv/createcv.component';


const routes: Routes = [
   {path:'', component :AppComponent},
   {path:'create' , component: CreatecvComponent}
  ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
