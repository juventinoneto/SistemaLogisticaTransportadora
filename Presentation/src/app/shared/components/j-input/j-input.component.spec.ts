import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { JInputComponent } from './j-input.component';

describe('JInputComponent', () => {
  let component: JInputComponent;
  let fixture: ComponentFixture<JInputComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ JInputComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(JInputComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
