import { DetailjComponent } from './detailj/detailj.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomePageComponent } from './home-page/home-page.component';
import { BusinessComponent } from './business/business.component';
import { OpinionComponent } from './opinion/opinion.component';
// import { DashboardComponent } from './dashboard/dashboard.component';
import { DetailsComponent } from './details/details.component';
import { DashboardHomeComponent } from './UserDashboard/dashboard-home/dashboard-home.component';
import { BlogPostComponent } from './UserDashboard/blog-post/blog-post.component';
import { AddNewPostComponent } from './UserDashboard/add-new-post/add-new-post.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { WeatherComponent } from './component/weather/weather.component';





const routes: Routes = [
  { path: "", component:HomePageComponent  },
  
  { path: "weather", component: WeatherComponent },
  { path: "business", component: BusinessComponent },
  // { path: "dashboard", component: DashboardComponent },
  { path: "details/:id", component: DetailsComponent },
  { path: "detailj/:id",component: DetailjComponent },
  { path: "Register", component: RegisterComponent },
  { path: "Login", component: LoginComponent },

  {
    path: "dashboard", children: [
      { path: "", component: DashboardHomeComponent },

      { path: "AllPosts", component: BlogPostComponent },
      { path: "AddNewPost", component: AddNewPostComponent },]
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
