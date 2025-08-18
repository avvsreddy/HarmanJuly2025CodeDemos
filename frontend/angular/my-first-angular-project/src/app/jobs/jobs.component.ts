import { Component } from '@angular/core';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-jobs',
  templateUrl: './jobs.component.html',
  styleUrls: ['./jobs.component.css'],
  imports: [NgFor]
})
export class JobsComponent {
  jobs = [
    {
      title: 'Frontend Developer',
      description: 'Build and maintain web applications using Angular.',
      location: 'Hyderabad'
    },
    {
      title: 'Backend Developer',
      description: 'Develop REST APIs and manage databases.',
      location: 'Bangalore'
    },
    {
      title: 'UI/UX Designer',
      description: 'Design user interfaces and improve user experience.',
      location: 'Remote'
    }
  ];
}
