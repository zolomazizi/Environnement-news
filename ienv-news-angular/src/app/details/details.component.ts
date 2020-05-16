
import { Component, OnInit } from '@angular/core';
import { DetailService } from '../services/detail.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit {
   detail;

  constructor(
    private detailService: DetailService,
    private route:ActivatedRoute,
    ) { }

  ngOnInit() {
    this.getDetailArticle();
  }

  getDetailArticle(){

    const detailId = +this.route.snapshot.paramMap.get('id');
    this.detailService.getById(detailId)
    .subscribe(
       data => this.detail = data
       )
   
   
  }

 
  }

    
  

