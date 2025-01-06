import { Directive, ElementRef, Renderer2, Input, OnDestroy, OnInit } from '@angular/core';

@Directive({
  selector: '[appObserveVisibility]',
  standalone: true
})
export class ObserveVisibilityDirective implements OnInit, OnDestroy {
  @Input() appObserveVisibility!: string; // Nome da classe de animação
  private observer!: IntersectionObserver;

  constructor(private el: ElementRef, private renderer: Renderer2) {}

  ngOnInit(): void {
    // Verifica se o código está sendo executado no lado do cliente (navegador)
    if (typeof window !== 'undefined' && 'IntersectionObserver' in window) {
      // Criação do IntersectionObserver
      this.observer = new IntersectionObserver(
        ([entry]) => {
          if (entry.isIntersecting) {
            // Adiciona a classe de animação quando o elemento entra na viewport
            this.renderer.addClass(this.el.nativeElement, this.appObserveVisibility);

            // Remove a classe após um tempo, para permitir que a animação reinicie
            setTimeout(() => {
              this.renderer.removeClass(this.el.nativeElement, this.appObserveVisibility);
            }, 1000); // Ajuste o tempo de acordo com a duração da animação
          }
        },
        { threshold: 0.1 } // Ajuste conforme necessário
      );

      // Observa o elemento
      this.observer.observe(this.el.nativeElement);
    } else {
      // Caso o IntersectionObserver não esteja disponível (exemplo: SSR)
      console.warn('IntersectionObserver não está disponível no ambiente atual.');
    }
  }

  ngOnDestroy(): void {
    // Desconecta o observer quando o componente for destruído
    if (this.observer) {
      this.observer.disconnect();
    }
  }
}
