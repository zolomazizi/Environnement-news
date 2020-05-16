import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NewsExComponent } from './news-ex.component';

describe('NewsExComponent', () => {
  let component: NewsExComponent;
  let fixture: ComponentFixture<NewsExComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NewsExComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewsExComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
