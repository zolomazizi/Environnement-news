import { Article } from './../models/article';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ArticleService {

  constructor( private http : HttpClient ) { }

  findAll(){
    return this.http.get<Article[]>("http://localhost:49367/api/Article/Article");
  }
}
