import { Injectable } from '@angular/core';
import { Article } from '../models/article';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PostArticleService {

  constructor(private http: HttpClient) { }
  PostArticl(userData: Article) {

    var ArtcileInfo = new Article();
    ArtcileInfo.Titre = userData.Titre
    ArtcileInfo.Description = userData.Description
    ArtcileInfo.Body = userData.Body
    ArtcileInfo.DateArticle = userData.DateArticle
    ArtcileInfo.CategorieID = userData.CategorieID
    ArtcileInfo.Status = userData.Status
    

    //allUserInfo.file = userData.file;
    // const formData: FormData = new FormData();
    // formData.append('ImageUser', fileToUpload, fileToUpload.name);
    // formData.append('email', userData.email);
    // formData.append('password', userData.password);
    // formData.append('confirmpassword', userData.confirmpassword);
    // formData.append('Name', userData.Name);
    // formData.append('lastName', userData.lastName);

    // allUserInfo.formData = formData

    return this.http.post("http://localhost:49367/api/Article/ArticleEnPost", ArtcileInfo);

  }
}
