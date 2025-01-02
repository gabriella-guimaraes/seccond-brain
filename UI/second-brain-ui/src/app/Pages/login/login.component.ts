import { Component } from '@angular/core';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
import { IntroComponent } from '../../Components/Organisms/intro/intro.component';


import { LoginFormComponent } from '../../Components/Organisms/login-form/login-form.component';
import { IconButtonComponent } from '../../Components/Atoms/icon-button/icon-button.component';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [MatButtonModule, MatIconModule, IconButtonComponent, IntroComponent, LoginFormComponent],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  
}
