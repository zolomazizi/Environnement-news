import { RouterModule, Router } from '@angular/router';
import { AuthentificationService } from 'src/app/services/authentification.service';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';
import { AuthentificationModule } from 'src/app/Models/authentification/authentification.module';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  // imageUrl: string = "/assets/img/default-image.png"
  // fileToUpload: File = null;
  register = new FormGroup(
    {
      Email: new FormControl,
      password: new FormControl,
      ConfirmPassword: new FormControl,
      Nom: new FormControl,
      Prenom: new FormControl,
      Tele: new FormControl,
      Role: new FormControl,
    }


  )
  reg:AuthentificationModule;



  constructor(private authService: AuthentificationService, private router: Router) { }

  ngOnInit() {
  }
  // handleFileInput(file: FileList) {
  //   this.fileToUpload = file.item(0);

  //   //Show image preview
  //   var reader = new FileReader();
  //   reader.onload = (event: any) => {
  //     this.imageUrl = event.target.result;
  //   }
  //   reader.readAsDataURL(this.fileToUpload);
  // }
  SignUp() {
    console.log(this.register);
    //console.log(Caption, Image);
    this.reg =this.register.value;
    this.authService.Register(this.reg).subscribe(() => {

      this.router.navigateByUrl('/Login')
    })



  }

}
