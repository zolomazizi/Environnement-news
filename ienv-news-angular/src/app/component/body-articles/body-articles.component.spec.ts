import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BodyArticlesComponent } from './body-articles.component';

describe('BodyArticlesComponent', () => {
  let component: BodyArticlesComponent;
  let fixture: ComponentFixture<BodyArticlesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BodyArticlesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BodyArticlesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
