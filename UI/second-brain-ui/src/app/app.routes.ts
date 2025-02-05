import { Routes } from '@angular/router';
import { HomeComponent } from './Pages/home/home.component';
import { LoginComponent } from './Pages/login/login.component';
import { SignUpComponent } from './Pages/sign-up/sign-up.component';

export const routes: Routes = [
    { path: "home", component: HomeComponent },
    { path: "", component: LoginComponent },
    { path: "sign-up", component: SignUpComponent }
];
