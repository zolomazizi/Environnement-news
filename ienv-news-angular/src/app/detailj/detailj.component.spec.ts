import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailjComponent } from './detailj.component';

describe('DetailjComponent', () => {
  let component: DetailjComponent;
  let fixture: ComponentFixture<DetailjComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DetailjComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailjComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
