import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet,HeaderComponent,FooterComponent],
  templateUrl: './app.component.html',
  //template:`<h1>this is html from component class</h1>
  //<hr>`,
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'my-first-angular-project';
}
