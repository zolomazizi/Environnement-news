import { Component, OnInit } from '@angular/core';
import { Article } from 'src/app/models/article';
import { SideService } from 'src/app/services/side.service';

@Component({
  selector: 'app-side-news',
  templateUrl: './side-news.component.html',
  styleUrls: ['./side-news.component.css']
})
export class SideNewsComponent implements OnInit {

  articles: Article[] =[];

  constructor(private sideService: SideService) { }

  ngOnInit() {
    this.getArticles();
  }

  getArticles(){
    this.sideService.findAll()
    .subscribe(articles => this.articles = articles )
  }

}
