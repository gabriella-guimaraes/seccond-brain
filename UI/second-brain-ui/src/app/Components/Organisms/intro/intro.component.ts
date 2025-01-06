import { Component, HostListener, ElementRef } from '@angular/core';
import { IconButtonComponent } from '../../Atoms/icon-button/icon-button.component';
import { ObserveVisibilityDirective } from '../../../utils/observe-visibility.directive';
import { rightFloatAnimation } from '../../../utils/animations';

@Component({
  selector: 'app-intro',
  standalone: true,
  imports: [IconButtonComponent, ObserveVisibilityDirective],
  templateUrl: './intro.component.html',
  styleUrl: './intro.component.css',
  animations: [rightFloatAnimation]
})
export class IntroComponent {

  isVisible: boolean = false;

  constructor(private elementRef: ElementRef) { }

  @HostListener('window:scroll', [])
  onScroll() {
    const sectionElement = this.elementRef.nativeElement.querySelector('.content');
    const rect = sectionElement.getBoundingClientRect();
    const windowHeight = window.innerHeight;
    const triggerHeight = windowHeight * 0.5;

    // Verificar se a parte superior do elemento está dentro da janela de visualização
    this.isVisible = rect.top < triggerHeight;
  }

}
