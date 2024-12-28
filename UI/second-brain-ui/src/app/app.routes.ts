import { Routes } from '@angular/router';
import { HomeComponent } from './Pages/home/home.component';
import { LoginComponent } from './Pages/login/login.component';
import { SignInComponent } from './Pages/sign-in/sign-in.component';

export const routes: Routes = [
    { path: "home", component: HomeComponent },
    { path: "", component: LoginComponent },
    { path: "sign-in", component: SignInComponent }
];
