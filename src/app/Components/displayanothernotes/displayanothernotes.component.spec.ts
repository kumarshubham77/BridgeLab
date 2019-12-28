import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplayanothernotesComponent } from './displayanothernotes.component';

describe('DisplayanothernotesComponent', () => {
  let component: DisplayanothernotesComponent;
  let fixture: ComponentFixture<DisplayanothernotesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DisplayanothernotesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DisplayanothernotesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
