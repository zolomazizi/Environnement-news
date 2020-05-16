import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBarComponent } from './component/layout/nav-bar/nav-bar.component';
import { FooterComponent } from './component/layout/footer/footer.component';
import { SliderComponent } from './component/slider/slider.component';
import { SideNewsComponent } from './component/layout/side-news/side-news.component';
import { BodyArticlesComponent } from './component/body-articles/body-articles.component';
import { FooterArticlesComponent } from './component/footer-articles/footer-articles.component';
import { HomePageComponent } from './home-page/home-page.component';
import { BusinessComponent } from './business/business.component';
import { OpinionComponent } from './opinion/opinion.component';
// import { DashboardComponent } from './dashboard/dashboard.component';
// import { LeftsidebarComponent } from './dashboard/leftsidebar/leftsidebar.component';
// import { MainpageComponent } from './dashboard/mainpage/mainpage.component';
// import { RightsidebarComponent } from './dashboard/rightsidebar/rightsidebar.component';
// import { TopcardsComponent } from './dashboard/topcards/topcards.component';
import { PubliciteComponent } from './component/layout/publicite/publicite.component';
import { DetailsComponent } from './details/details.component';
import { AboutComponent } from './about/about.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
// import { RatingModule } from 'ng-starrating';
import { DetailjComponent } from './detailj/detailj.component';
import { DashboardHomeComponent } from './UserDashboard/dashboard-home/dashboard-home.component';
import { BlogPostComponent } from './UserDashboard/blog-post/blog-post.component';
import { AddNewPostComponent } from './UserDashboard/add-new-post/add-new-post.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { WeatherComponent } from './component/weather/weather.component';
import { NewsExComponent } from './component/news-ex/news-ex.component';
@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    FooterComponent,
    NewsExComponent,
    SliderComponent,
    SideNewsComponent,
    BodyArticlesComponent,
    FooterArticlesComponent,
    HomePageComponent,
    BusinessComponent,
    RegisterComponent,
    LoginComponent,
    WeatherComponent,
    OpinionComponent,
    // DashboardComponent,
    // LeftsidebarComponent,
    // MainpageComponent,
    // RightsidebarComponent,
    // TopcardsComponent,
    PubliciteComponent,
    DashboardHomeComponent,
    AddNewPostComponent,
    BlogPostComponent,
    DetailsComponent,
    AboutComponent,
    DetailjComponent,
    WeatherComponent,
    NewsExComponent
  ],
  imports: [
    BrowserModule,
    // RatingModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule,

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
