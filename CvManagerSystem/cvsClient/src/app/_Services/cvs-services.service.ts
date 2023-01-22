import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs';
import { environment } from 'src/environments/environment';
import { cvs } from '../_model/cvs';
import { ResponseDto } from '../_model/response';

@Injectable({
  providedIn: 'root'
})

export class CvsServicesService {
baseUrl=environment.apiUrl;
  constructor(private http:HttpClient) { }

  getCvs(){
    return this.http.get<ResponseDto>(this.baseUrl+'CVsApi',{observe:'response'}).pipe(map(response=>{
      return response.body
    }))
  }
  deleteCvs(id:number){

    return this.http.delete(this.baseUrl+'CVsApi?id='+id);
  }
  updateCvs(cv:cvs){
    return this.http.put<cvs>(this.baseUrl, cv).pipe(
      map((obj) => obj));

  }

  getbyId(id: number){
    return this.http.get<ResponseDto>(this.baseUrl+'CVsApi/'+id).pipe(
      map((obj) => obj)
    )
  }

}
