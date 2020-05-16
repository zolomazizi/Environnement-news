import { TestBed } from '@angular/core/testing';

import { ServicesdetailjService } from './servicesdetailj.service';

describe('ServicesdetailjService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ServicesdetailjService = TestBed.get(ServicesdetailjService);
    expect(service).toBeTruthy();
  });
});
