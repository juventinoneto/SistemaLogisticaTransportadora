import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { JDataTableComponent } from './j-data-table.component';

describe('JDataTableComponent', () => {
  let component: JDataTableComponent;
  let fixture: ComponentFixture<JDataTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ JDataTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(JDataTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
