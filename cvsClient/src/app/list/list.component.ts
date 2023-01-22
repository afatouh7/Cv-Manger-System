import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { cvs } from '../_model/cvs';
import { CvsServicesService } from '../_Services/cvs-services.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {

  title = 'Cvs Mangment System ';
  cvData : cvs[]=[];

  constructor(private cvsService:CvsServicesService,private router: Router) {

  }
   ngOnInit(): void {
     this.getCvs();
   }
   getCvs(){
     this.cvsService.getCvs().subscribe(res=>{
       this.cvData=res?.result;
     })

   }
   deleteCv(id:number): void{
     this.cvsService.deleteCvs(id).subscribe(()=>{
       window.location.reload();
     })
   }
  edit(data:cvs){
   this.cvsService.updateCvs
  }

}
