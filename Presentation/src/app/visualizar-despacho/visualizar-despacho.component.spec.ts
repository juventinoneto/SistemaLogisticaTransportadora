import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VisualizarDespachoComponent } from './visualizar-despacho.component';

describe('VisualizarDespachoComponent', () => {
  let component: VisualizarDespachoComponent;
  let fixture: ComponentFixture<VisualizarDespachoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VisualizarDespachoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VisualizarDespachoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
