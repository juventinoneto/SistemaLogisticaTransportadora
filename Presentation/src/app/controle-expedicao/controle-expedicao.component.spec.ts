import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ControleExpedicaoComponent } from './controle-expedicao.component';

describe('ControleExpedicaoComponent', () => {
  let component: ControleExpedicaoComponent;
  let fixture: ComponentFixture<ControleExpedicaoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ControleExpedicaoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ControleExpedicaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
