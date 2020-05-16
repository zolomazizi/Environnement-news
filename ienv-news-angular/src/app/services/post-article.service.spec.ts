import { TestBed } from '@angular/core/testing';

import { PostArticleService } from './post-article.service';

describe('PostArticleService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PostArticleService = TestBed.get(PostArticleService);
    expect(service).toBeTruthy();
  });
});
