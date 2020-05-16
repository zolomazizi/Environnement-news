import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DetailjService {
  baseUrl="http://localhost:49367/api/Journalist/journalistSelect";
  constructor( private http : HttpClient ) { }
  
  getByIdd(id):Observable<any>{

    const url=`${this.baseUrl}/${id}`;
    return this.http.get(url);
}}
