import { TestBed } from '@angular/core/testing';

import { BicycleService } from './bicycle.service';

describe('BicycleService', () => {
  let service: BicycleService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BicycleService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
