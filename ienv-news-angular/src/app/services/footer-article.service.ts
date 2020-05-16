import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Article } from '../models/article';

@Injectable({
  providedIn: 'root'
})
export class FooterArticleService {
  constructor( private http : HttpClient ) { }

  findAll(){
    return this.http.get<Article[]>("http://localhost:49367/api/Article/DaysArticle");
  }
}
