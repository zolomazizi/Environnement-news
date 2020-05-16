import { Component, OnInit } from '@angular/core';
import { ArticleService } from 'src/app/services/article.service';
import { Article } from 'src/app/models/article';
import { SlideService } from 'src/app/services/slide.service';


@Component({
  selector: 'app-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.css']
})
export class SliderComponent implements OnInit {
  
 

  articles: Article[] =[];

  constructor(private slideService: SlideService) { }

  ngOnInit() {
    this.getArticles();
  }

  getArticles(){
    this.slideService.findAll()
    .subscribe(articles => this.articles = articles )
  }

}
