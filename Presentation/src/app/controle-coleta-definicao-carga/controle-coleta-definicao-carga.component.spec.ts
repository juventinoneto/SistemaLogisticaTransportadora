import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ControleColetaDefinicaoCargaComponent } from './controle-coleta-definicao-carga.component';

describe('ControleColetaDefinicaoCargaComponent', () => {
  let component: ControleColetaDefinicaoCargaComponent;
  let fixture: ComponentFixture<ControleColetaDefinicaoCargaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ControleColetaDefinicaoCargaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ControleColetaDefinicaoCargaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
