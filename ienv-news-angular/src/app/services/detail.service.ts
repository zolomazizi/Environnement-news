import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class DetailService {
   baseUrl="http://localhost:49367/api/Article/DetaileArticle";
  constructor( private http : HttpClient ) { }
  
  getById(id):Observable<any>{

    const url=`${this.baseUrl}/${id}`;
    return this.http.get(url);
   
    
  }
}
