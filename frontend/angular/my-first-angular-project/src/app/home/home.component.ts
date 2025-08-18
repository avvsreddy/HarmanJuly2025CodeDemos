import { NgFor } from '@angular/common';
import { Component, input, output, signal } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { User } from '../../models/user';


@Component({
  selector: 'app-home',
  imports: [FormsModule,NgFor],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

// //name:string = "Ramesh";  
// name  = signal<string>('Ramesh');
// isActive:boolean=false;
// picture:string='https://randomuser.me/api/portraits/men/15.jpg'

// btnClicked()
// {
//   //alert('button clicked')
//   //this.name = "Name changed";
//   this.name.set('Name changed');
// }

users:User[] = [
  {
    id:1,
    name:'Ramesh',
    picture:'https://randomuser.me/api/portraits/men/86.jpg',
    isActive:true
  },
  {id:2,
    name:'Girish',
    picture:'https://randomuser.me/api/portraits/men/42.jpg',
  isActive:false
  },
  {
    id:3,
    name:'Somesh',
    picture:'https://randomuser.me/api/portraits/men/62.jpg',
  isActive:false
  },
     {
      id:3,
    name:'Somesh',
    picture:'https://randomuser.me/api/portraits/men/62.jpg',
  isActive:true
  },
     {id:3,
    name:'Somesh',
    picture:'https://randomuser.me/api/portraits/men/62.jpg',
  isActive:false},
     {id:3,
    name:'Somesh',
    picture:'https://randomuser.me/api/portraits/men/62.jpg',
  isActive:false},
     {id:3,
    name:'Somesh',
    picture:'https://randomuser.me/api/portraits/men/62.jpg',
  isActive:false},
     {id:3,
    name:'Somesh',
    picture:'https://randomuser.me/api/portraits/men/62.jpg',
  isActive:true},
     {id:3,
    name:'Somesh',
    picture:'https://randomuser.me/api/portraits/men/62.jpg',
  isActive:false},
]



}
