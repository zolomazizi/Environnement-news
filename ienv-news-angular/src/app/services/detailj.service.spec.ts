import { TestBed } from '@angular/core/testing';

import { DetailjService } from './detailj.service';

describe('DetailjService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: DetailjService = TestBed.get(DetailjService);
    expect(service).toBeTruthy();
  });
});
