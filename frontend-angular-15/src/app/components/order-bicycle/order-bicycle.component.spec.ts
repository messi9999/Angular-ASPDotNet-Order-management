import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OrderBicycleComponent } from './order-bicycle.component';

import "bootstrap/dist/css/bootstrap.min.css";

describe('OrderBicycleComponent', () => {
  let component: OrderBicycleComponent;
  let fixture: ComponentFixture<OrderBicycleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OrderBicycleComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(OrderBicycleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
