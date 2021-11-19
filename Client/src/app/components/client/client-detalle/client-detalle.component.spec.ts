import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClientDetalleComponent } from './client-detalle.component';

describe('ClientDetalleComponent', () => {
  let component: ClientDetalleComponent;
  let fixture: ComponentFixture<ClientDetalleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ClientDetalleComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ClientDetalleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
