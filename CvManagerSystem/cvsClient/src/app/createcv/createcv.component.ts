import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { cvs } from '../_model/cvs';
import { CvsServicesService } from '../_Services/cvs-services.service';

@Component({
  selector: 'app-createcv',
  templateUrl: './createcv.component.html',
  styleUrls: ['./createcv.component.css']
})
export class CreatecvComponent implements OnInit {

  constructor(private cvsService:CvsServicesService,private router: Router ) { }

  cv :any;

  ngOnInit(): void {
  }
  createCv():void{
    this.cvsService.updateCvs(this.cv).subscribe(()=>{
      this.router.navigate(['/']);
    })
  }
  cancel(): void {
    this.router.navigate(['/'])
  }

}
