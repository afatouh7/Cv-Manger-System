import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { cvs } from './_model/cvs';
import { ResponseDto } from './_model/response';
import { CvsServicesService } from './_Services/cvs-services.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }


}
