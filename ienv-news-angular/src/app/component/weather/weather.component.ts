import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.css']
})
export class WeatherComponent implements OnInit {

  WeatherData:any;
  constructor() { }

  ngOnInit() {
    this.getWeatherData();
    console.log(this.WeatherData);
  }

  getWeatherData(){
  //   let  data = JSON.parse('{"coord": { "lon": 139,"lat": 35},"weather": [{"id": 800,"main": "Clear","description": "clear sky","icon": "01n"}],"base": "stations","main": {"temp": 281.52,"feels_like": 278.99,"temp_min": 280.15,"temp_max": 283.71,"pressure": 1016,"humidity": 93},"wind": {"speed": 0.47,"deg": 107.538},"clouds": {"all": 2},"dt": 1560350192,"sys": {"type": 3,"id": 2019346,"message": 0.0065,"country": "JP","sunrise": 1560281377,"sunset": 1560333478},"timezone": 32400,"id": 1851632,"name": "Shuzenji","cod": 200}')
  // this.setWeatherData(data);

  fetch('https://api.openweathermap.org/data/2.5/weather?q=rabat&appid=ff1bc4683fc7325e9c57e586c20cc03e')
    .then(response=>response.json())
    .then(data=>{this.setWeatherData(data);})
  }

  setWeatherData(data){
    
    this.WeatherData = data;
    let sunsetTime = new Date(this.WeatherData.sys.sunset * 1000);
    this.WeatherData.sunset_time = sunsetTime.toLocaleTimeString();
    let currentDate = new Date();
    this.WeatherData.isDay = (currentDate.getTime() < sunsetTime.getTime());
    this.WeatherData.temp_celcius = (this.WeatherData.main.temp - 273.15).toFixed(0);
    this.WeatherData.temp_min = (this.WeatherData.main.temp_min - 273.15).toFixed(0);
    this.WeatherData.temp_max = (this.WeatherData.main.temp_max - 273.15).toFixed(0);
    this.WeatherData.temp_feels_like = (this.WeatherData.main.feels_like - 273.15).toFixed(0);
  }
}
