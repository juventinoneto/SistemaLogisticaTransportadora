import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PainelGeralComponent } from './painel-geral.component';

describe('PainelGeralComponent', () => {
  let component: PainelGeralComponent;
  let fixture: ComponentFixture<PainelGeralComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PainelGeralComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PainelGeralComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
