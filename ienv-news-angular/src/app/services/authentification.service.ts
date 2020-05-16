import { AuthentificationModule } from './../models/authentification/authentification.module';

import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { FormGroup } from '@angular/forms';

@Injectable({
  providedIn: 'root'
})
export class AuthentificationService {

  constructor(private http: HttpClient) { }

  Register(userData: AuthentificationModule) {

    var allUserInfo = new AuthentificationModule();
    allUserInfo.Email = userData.Email
    allUserInfo.password = userData.password
    allUserInfo.ConfirmPassword = userData.ConfirmPassword
    allUserInfo.Nom = userData.Nom
    allUserInfo.Prenom = userData.Prenom
    allUserInfo.Tele = userData.Tele
    // allUserInfo.Statu =userData.Statu
    allUserInfo.Role = userData.Role

    //allUserInfo.file = userData.file;
    // const formData: FormData = new FormData();
    // formData.append('ImageUser', fileToUpload, fileToUpload.name);
    // formData.append('email', userData.email);
    // formData.append('password', userData.password);
    // formData.append('confirmpassword', userData.confirmpassword);
    // formData.append('Name', userData.Name);
    // formData.append('lastName', userData.lastName);

    // allUserInfo.formData = formData

    return this.http.post("http://localhost:49367/api/Account/Register", allUserInfo);

  }
  Login(userName, password) {
    var data = "username=" + userName + "&password=" + password + "&grant_type=password";
    console.log(data)
    var reqHeader = new HttpHeaders({ 'Content-Type': 'application/x-www-urlencoded', 'No-Auth': 'True' });
    return this.http.post("http://localhost:49367/token", data, { headers: reqHeader });
  }
  // httpOptions = {
  //   headers: new HttpHeaders({
  //     'Authorization': 'Bearer ' + localStorage.getItem('userToken')}
  //   })
  // };
  getUserClaims() {
    //var l = localStorage.setItem('userToken', data.access_token);
    ///////
    var hesdersApi = new Headers();
    if (localStorage.getItem('userToken')) {
      console.log(localStorage.getItem('userToken'))
      hesdersApi.append('Authorization', 'Bearer' + localStorage.getItem('userToken'))
    }
    /////////

    return this.http.get('http://localhost:51473/api/Account/GetUserClaims',
      {
        headers: new HttpHeaders({
          'Authorization': 'Bearer ' + localStorage.getItem('userToken')
        })
      });
  }

}

