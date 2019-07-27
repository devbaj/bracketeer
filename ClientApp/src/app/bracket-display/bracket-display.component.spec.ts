import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BracketDisplayComponent } from './bracket-display.component';

describe('BracketDisplayComponent', () => {
  let component: BracketDisplayComponent;
  let fixture: ComponentFixture<BracketDisplayComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BracketDisplayComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BracketDisplayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
