import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { JTextareaComponent } from './j-textarea.component';

describe('JTextareaComponent', () => {
  let component: JTextareaComponent;
  let fixture: ComponentFixture<JTextareaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ JTextareaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(JTextareaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
