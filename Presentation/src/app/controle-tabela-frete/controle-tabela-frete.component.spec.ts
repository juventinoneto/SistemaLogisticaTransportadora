import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ControleTabelaFreteComponent } from './controle-tabela-frete.component';

describe('ControleTabelaFreteComponent', () => {
  let component: ControleTabelaFreteComponent;
  let fixture: ComponentFixture<ControleTabelaFreteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ControleTabelaFreteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ControleTabelaFreteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
