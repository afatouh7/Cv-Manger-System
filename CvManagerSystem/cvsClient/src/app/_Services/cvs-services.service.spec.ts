import { TestBed } from '@angular/core/testing';

import { CvsServicesService } from './cvs-services.service';

describe('CvsServicesService', () => {
  let service: CvsServicesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CvsServicesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
