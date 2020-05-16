import { TestBed } from '@angular/core/testing';

import { ArticlePostService } from './article-post.service';

describe('ArticlePostService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ArticlePostService = TestBed.get(ArticlePostService);
    expect(service).toBeTruthy();
  });
});
