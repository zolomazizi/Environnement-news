import { TestBed } from '@angular/core/testing';

import { FooterArticleService } from './footer-article.service';

describe('FooterArticleService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: FooterArticleService = TestBed.get(FooterArticleService);
    expect(service).toBeTruthy();
  });
});
