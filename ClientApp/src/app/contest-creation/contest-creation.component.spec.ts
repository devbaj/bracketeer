import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ContestCreationComponent } from './contest-creation.component';

describe('ContestCreationComponent', () => {
  let component: ContestCreationComponent;
  let fixture: ComponentFixture<ContestCreationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ContestCreationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ContestCreationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
