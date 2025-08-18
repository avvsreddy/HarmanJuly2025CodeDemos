import { Component } from '@angular/core';
import { CourseRegistration } from '../../models/course-registration';
import { FormsModule } from '@angular/forms';
import { NgFor, NgIf } from '@angular/common';

@Component({
  selector: 'app-course',
  imports: [FormsModule,NgFor,NgIf],
  templateUrl: './course.component.html',
  styleUrl: './course.component.css'
})
export class CourseComponent {

course:CourseRegistration = {
id: 0,
studentName: '',
email: '',
phone: '',
gender: '',
courseName: '',
subscription: false,
registrationDate: new Date()



};

courses:string[] = ['Angular', 'React', 'Vue', '.Net','Java'];

onSubmit(){
  //console.log(formCtrl);
  //console.log(this.course);
  // Here you can add logic to handle the form submission, like sending data to a server
}


}
