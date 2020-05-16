import { PostsAvisModule } from './../../Models/posts-avis/posts-avis.module';
import { PostesService } from 'src/app/services/postes.service';
import { Component, OnInit } from '@angular/core';
import { Article } from 'src/app/models/article';
import { ArticleService } from 'src/app/services/article.service';

@Component({
  selector: 'app-blog-post',
  templateUrl: './blog-post.component.html',
  styleUrls: ['./blog-post.component.css']
})
export class BlogPostComponent implements OnInit {
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
