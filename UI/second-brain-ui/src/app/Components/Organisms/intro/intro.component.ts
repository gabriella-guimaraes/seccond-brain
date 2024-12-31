import { Component } from '@angular/core';
import { IconButtonComponent } from '../../Atoms/icon-button/icon-button.component';

@Component({
  selector: 'app-intro',
  standalone: true,
  imports: [IconButtonComponent],
  templateUrl: './intro.component.html',
  styleUrl: './intro.component.css'
})
export class IntroComponent {

}
