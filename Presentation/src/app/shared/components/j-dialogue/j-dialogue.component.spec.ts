import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { JDialogueComponent } from './j-dialogue.component';

describe('JDialogueComponent', () => {
  let component: JDialogueComponent;
  let fixture: ComponentFixture<JDialogueComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ JDialogueComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(JDialogueComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
