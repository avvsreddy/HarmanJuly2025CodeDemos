import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { ServicesComponent } from './services/services.component';
import { ContactComponent } from './contact/contact.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { JobsComponent } from './jobs/jobs.component';
import { CourseComponent } from './course/course.component';

export const routes: Routes = 
[
    {
        path:'',
        redirectTo:'home',
        pathMatch:'full'
    },
    {
        path:'home',
        component:HomeComponent
    },
    {
        path:'about',
        component:AboutComponent
    },
    {
        path:'services',
        component:ServicesComponent
    },
    {
        path:'contact',
        component:ContactComponent
    },
    {
        path:'jobs',
        component:JobsComponent
    },
    {
        path:'course',
        component:CourseComponent
    },
    {
        path:'**',
        component:NotFoundComponent
    }
];

