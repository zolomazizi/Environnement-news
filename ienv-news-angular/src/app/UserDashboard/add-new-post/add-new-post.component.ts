import { PostArticleService } from './../../services/post-article.service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { RouterModule, Router } from '@angular/router';
import { Article } from 'src/app/models/article';
// import { constructor } from 'jasmine';

@Component({
  selector: 'app-add-new-post',
  templateUrl: './add-new-post.component.html',
  styleUrls: ['./add-new-post.component.css']
})
export class AddNewPostComponent implements OnInit {

  Poarticle = new FormGroup(
    {
      Titre: new FormControl,
      Description: new FormControl,
      Body: new FormControl,
      CategorieID: new FormControl,
      Status : new FormControl,
      
    });

    reg:Article;

    constructor(private PostArticleService: PostArticleService, private router: Router) { }

  ngOnInit() {
  }

  PostArticle() {
    console.log(this.Poarticle);
    //console.log(Caption, Image);
    this.reg =this.Poarticle.value;
    this.PostArticleService.PostArticl(this.reg).subscribe(() => {

      this.router.navigateByUrl('/dashboard')
    })



  }

}
