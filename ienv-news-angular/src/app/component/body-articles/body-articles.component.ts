import { Component, OnInit } from '@angular/core';
import { ArticleService } from 'src/app/services/article.service';
import { Article } from 'src/app/models/article';

@Component({
  selector: 'app-body-articles',
  templateUrl: './body-articles.component.html',
  styleUrls: ['./body-articles.component.css']
})
export class BodyArticlesComponent implements OnInit {

  articles: Article[] =[];

  constructor(private articleService: ArticleService) { }

  ngOnInit() {
    this.getArticles();
  }

  getArticles(){
    this.articleService.findAll()
    .subscribe(articles => this.articles = articles )
  }

}
