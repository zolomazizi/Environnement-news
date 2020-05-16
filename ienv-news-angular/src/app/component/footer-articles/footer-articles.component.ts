import { Component, OnInit } from '@angular/core';
import { Article } from 'src/app/models/article';
import { FooterArticleService } from 'src/app/services/footer-article.service';

@Component({
  selector: 'app-footer-articles',
  templateUrl: './footer-articles.component.html',
  styleUrls: ['./footer-articles.component.css']
})
export class FooterArticlesComponent implements OnInit {

  articles: Article[] =[];

  constructor(private footerArticleService: FooterArticleService) { }

  ngOnInit() {
    this.getArticles();
  }

  getArticles(){
    this.footerArticleService.findAll()
    .subscribe(articles => this.articles = articles )
  }
}
