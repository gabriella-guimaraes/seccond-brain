import { Component, HostListener, ElementRef, Renderer2, OnInit, OnDestroy, Inject, PLATFORM_ID } from '@angular/core';
import { isPlatformBrowser } from '@angular/common';
import { IconButtonComponent } from '../../Atoms/icon-button/icon-button.component';
import { rightFloatAnimation, floatAnimation } from '../../../utils/animations';

@Component({
  selector: 'app-intro',
  standalone: true,
  imports: [IconButtonComponent],
  templateUrl: './intro.component.html',
  styleUrl: './intro.component.css',
  animations: [rightFloatAnimation, floatAnimation]
})
export class IntroComponent implements OnInit {
  isVisible: boolean = false;
  isMobile: boolean = false;
  private observer: IntersectionObserver | null = null;

  constructor(private elementRef: ElementRef, private render: Renderer2, @Inject(PLATFORM_ID) private platformId: Object) {}

  ngOnInit() {
    this.checkScreenWidth();

    if (isPlatformBrowser(this.platformId)) {
      this.initIntersectionObserver();
    }
  }

  ngOnDestroy() {
    if (this.observer) {
      this.observer.disconnect(); // Remove o observador ao destruir o componente
    }
  }

  @HostListener('window:resize', ['$event'])
  onResize(event: any) {
    this.checkScreenWidth
  }

  checkScreenWidth() {
    if (isPlatformBrowser(this.platformId)) {
      const sectionElement = this.elementRef.nativeElement.querySelector('#animationTrigger');
      if (window.innerWidth <= 768) {
        this.render.addClass(sectionElement, 'mobile');
        this.isMobile = true;
      } else {
        this.render.removeClass(sectionElement, 'mobile');
        this.isMobile = false;
      }
    }
  }


  // @HostListener('window:scroll', [])
  // onWindowScroll() {
  //   const element = this.elementRef.nativeElement.querySelector('.content');
  //   const rect = element.getBoundingClientRect();
  //   const windowHeight = window.innerHeight;
  //   const triggerHeight = windowHeight * 1; // Defina a porcentagem da altura da janela aqui

  //   // Verificar se a parte superior do elemento está dentro da janela de visualização
  //   this.isVisible = rect.top < triggerHeight;
  // }

  initIntersectionObserver() {
    const element = this.elementRef.nativeElement.querySelector('#animationTrigger');

    this.observer = new IntersectionObserver(
      (entries) => {
        entries.forEach((entry) => {
          this.isVisible = entry.isIntersecting; // Atualiza a visibilidade com base na interseção
        });
      },
      { threshold: 0.5 } // Dispara quando 50% do elemento está visível
    );

    if (element) {
      this.observer.observe(element);
    }
  }

}
