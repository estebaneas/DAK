import { ComponentFixture, TestBed } from '@angular/core/testing';

import { IngresarPaqueteComponent } from './ingresar-paquete.component';

describe('IngresarPaqueteComponent', () => {
  let component: IngresarPaqueteComponent;
  let fixture: ComponentFixture<IngresarPaqueteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ IngresarPaqueteComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(IngresarPaqueteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
