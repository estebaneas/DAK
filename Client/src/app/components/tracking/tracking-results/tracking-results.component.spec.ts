import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TrackingResultsComponent } from './tracking-results.component';

describe('TrackingResultsComponent', () => {
  let component: TrackingResultsComponent;
  let fixture: ComponentFixture<TrackingResultsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TrackingResultsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TrackingResultsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
