import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TrackingFooterComponent } from './tracking-footer.component';

describe('TrackingFooterComponent', () => {
  let component: TrackingFooterComponent;
  let fixture: ComponentFixture<TrackingFooterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TrackingFooterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TrackingFooterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
