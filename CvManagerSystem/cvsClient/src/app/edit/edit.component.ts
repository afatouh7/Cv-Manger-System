import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CvsServicesService } from '../_Services/cvs-services.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {

  constructor(private cvsService:CvsServicesService,private router: Router,    private route: ActivatedRoute ) { }

  cv :any;

  ngOnInit(): void {

    
  }
  EditCv():void{
    this.cvsService.updateCvs(this.cv).subscribe(()=>{
      this.router.navigate(['/']);
    })
  }
  cancel(): void {
    this.router.navigate(['/'])
  }
}
