import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { ServicesComponent } from './ourservices/services.component';
import { ContactComponent } from './contact/contact.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { JobsComponent } from './jobs/jobs.component';
import { ProfileComponent } from './profile/profile.component';
import { CourseComponent } from './course/course.component';
import { ProductListComponent } from './product-list/product-list.component';
import { ProductAddComponent } from './product-add/product-add.component';

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
        path:'profile',
        component:ProfileComponent
    },
    {
        path:'course',
        component:CourseComponent
    },
     {
        path:'product-list',
        component:ProductListComponent
    },
     {
        path:'product-add',
        component:ProductAddComponent
    },
    {
        path:'**',
        component:NotFoundComponent
    }
];

