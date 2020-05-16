import { DetailjService } from './../services/detailj.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-detailj',
  templateUrl: './detailj.component.html',
  styleUrls: ['./detailj.component.css']
})
export class DetailjComponent implements OnInit {

  journalist;

  constructor(
    private route:ActivatedRoute,
    private detailjService:DetailjService
    ) { }

  ngOnInit() {
     this.getDetailJournaliste();
  }
  getDetailJournaliste(){

    const journalistId = +this.route.snapshot.paramMap.get('id');
    this.detailjService.getByIdd(journalistId )
    .subscribe(
       data => this.journalist = data
       )

}}
